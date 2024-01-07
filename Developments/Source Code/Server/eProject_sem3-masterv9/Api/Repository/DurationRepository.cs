using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Duration;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class DurationRepository : IDuration
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public DurationRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<DurationDto>> GetDurations()
        {
            var list = await _db.Durations.ToListAsync();
            var res = new List<DurationDto>();
            foreach (var duration in list)
            {
                res.Add(_mapper.Map<DurationDto>(duration));
            }
            return res;
        }

        public async Task<DtoResult<DurationDto>> Create(DurationDto model)
        {
            try
            {
                /*var duration = await _db.Durations.FirstOrDefaultAsync(x => x.Id == model.Id);
                if (duration != null)
                {
                    return false;
                }*/
                Duration newduration = new Duration()
                {
                    Package_Id = model.package_id,
                    Validate = model.validate,
                    Time = model.time,
                    Price = model.price,
                    Description = model.description
                };
                _db.Durations.Add(newduration);
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

        public async Task<bool> Remove(int id)
        {
            try
            {
                var duration = await _db.Durations.FirstOrDefaultAsync(x => x.Id == id);
                if (duration != null)
                {
                    _db.Durations.Remove(duration);
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

        public async Task<DtoResult<DurationDto>> Update(DurationDto model)
        {
            try
            {
                var existdu = await _db.Durations.FirstOrDefaultAsync(x => x.Id == model.id);
                if (existdu != null)
                {
                    existdu.Package_Id = model.package_id;
                    existdu.Time = model.time;
                    existdu.Price = model.price;
                    existdu.Validate = model.validate;
                    existdu.Description = model.description;
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

        public async Task<IEnumerable<DurationInfo>> GetInfor()
        {
            var list = await _db.Durations.ToListAsync();
            var resList = new List<DurationInfo>();
            
            foreach (var item in list)
            {
                var res = new DurationInfo();
                res.Id = item.Id;

                var connectTypeFirstLetter = _db.Durations
                .Where(d => d.Id == item.Id)
                .Select(d => d.Package!.Connect_type!.First_Letter)
                .FirstOrDefault();

                res.name = connectTypeFirstLetter + item.Time;
                res.price = item.Price + "/" + item.Time + " " + item.Validate;

                var packageName = _db.Durations
                .Where(d => d.Id == item.Id)
                .Select(d => d.Package!.Name)
                .FirstOrDefault();

                res.package_name = packageName!;

                resList.Add(res);
            }
            return resList;
        }
    }
}

