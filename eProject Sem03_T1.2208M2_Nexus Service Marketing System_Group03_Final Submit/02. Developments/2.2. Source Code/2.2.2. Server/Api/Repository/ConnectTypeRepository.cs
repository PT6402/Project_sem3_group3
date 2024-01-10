using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.ConnectType;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class ConnectTypeRepository : IConnectType
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public ConnectTypeRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<DtoResult<ConnectTypeRes>> Create(ConnectTypeRes model)
        {
            try
            {
                var connect = await _db.Connect_types.FirstOrDefaultAsync(x => x.Name == model.name);
                if (connect != null)
                {
                    return new()
                    {
                        Status = false,
                        Message = "already exist"
                    };
                }
                Connect_type newconnect = new Connect_type()
                {
                    Name = model.name,
                    First_Letter = model.firstLetter,
                    Description = model.description,
                    Security_Deposit = model.deposit
                };
                _db.Connect_types.Add(newconnect);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create successfully"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<List<ConnectTypeDto>> GetConnect_Types()
        {
            var connectTypes = await _db.Connect_types
            .Include(x => x.Packages)
            .Select(connectType => new ConnectTypeDto
            {
                id = connectType.Id,
                name = connectType.Name,
                firstLetter = connectType.First_Letter,
                description = connectType.Description,
                deposit = connectType.Security_Deposit,
                packages = connectType.Packages!.Select(package => new Packages { package_id = package.Id }).ToList()
            }).ToListAsync();

            return connectTypes;

        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                var connect = await _db.Connect_types.FirstOrDefaultAsync(x => x.Id == id);
                if (connect != null)
                {
                    _db.Connect_types.Remove(connect);
                    await _db.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<DtoResult<ConnectTypeRes>> Update(ConnectTypeRes model)
        {
            try
            {
                var existconnect = await _db.Connect_types.FirstOrDefaultAsync(x => x.Id == model.id);
                if (existconnect != null)
                {

                    existconnect.Name = model.name ?? existconnect.Name;
                    existconnect.First_Letter = model.firstLetter ?? existconnect.First_Letter;
                    existconnect.Description = model.description ?? existconnect.Description;
                    existconnect.Security_Deposit = model.deposit;

                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "update successfully"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "update fail"
                };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }
    }
}

