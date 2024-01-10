using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Address;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Api.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public AddressRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        //Create
        public async Task<DtoResult<AddressDto>> Create(AddressDto model)
        {
            try
            {
                var add = await _db.Address.FirstOrDefaultAsync(
                    a => a.Address_full.Equals(model.Address_full));
                if (add != null)
                {
                    return new DtoResult<AddressDto>
                    {
                        Status = false,
                        Message = "Address already exits"
                    };
                }
                Addresses newAdd = new Addresses()
                {

                    Address_full = model.Address_full,
                    Phone_code = model.Phone_code,
                    Province_code = model.Province_code,
                    District_code = model.District_code,
                    Ward_code = model.Ward_code
                };
                _db.Address.Add(newAdd);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create successfully"
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                return new()
                {
                    Status = false,
                    Message = ex.InnerException?.Message
                };
            }
        }

        public async Task<DtoResult<AddressDto>> DeleteAddress(int id)
        {
            try
            {
                var add = await _db.Address.FirstOrDefaultAsync(a => a.Id.Equals(id));
                if (add != null)
                {
                    _db.Address.Remove(add);
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Delete successfully"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "Delete fail!"
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

        public async Task<DtoResult<AddressDto>> EditAddress(AddressDto model)
        {
            try
            {
                var add = await _db.Address.FirstOrDefaultAsync(a => a.Id.Equals(model.Id));
                if (add != null)
                {
                    add.Address_full = model.Address_full;
                    add.Phone_code = model.Phone_code;
                    add.Province_code = model.Province_code;
                    add.District_code = model.District_code;
                    add.Ward_code = model.Ward_code;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully!"
                    };
                }
                else
                {
                    return new()
                    {
                        Status = false,
                        Message = "Update fail"
                    };
                }
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

        public async Task<IEnumerable<AddressDto>> GetAll()
        {
            var addList = await _db.Address.ToListAsync();
            var listDto = new List<AddressDto>();
            foreach (var address in addList)
            {
                listDto.Add(_mapper.Map<AddressDto>(address));
            }
            return listDto;
        }

        public async Task<IEnumerable<AddressDto>> GetByCity(string city)
        {
            try
            {
                var add = await _db.Address.Where(
                    a => EF.Functions.Like(a.Province_code, $"%{city}%")).ToListAsync();
                var listDto = new List<AddressDto>();
                if (add != null)
                {
                    foreach (var address in add)
                    {
                        listDto.Add(_mapper.Map<AddressDto>(address));
                    }
                    return listDto.ToList();
                }
                else
                {
                    return null!;
                }
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AddressDto>();
            }
        }

        public async Task<IEnumerable<AddressDto>> GetByDistrict(string district)
        {
            try
            {
                var add = await _db.Address.Where(
                    a => EF.Functions.Like(a.District_code, $"%{district}%")).ToListAsync();
                var listDto = new List<AddressDto>();
                if (add != null)
                {
                    foreach (var address in add)
                    {
                        listDto.Add(_mapper.Map<AddressDto>(address));
                    }
                    return listDto.ToList();
                }
                else
                {
                    return Enumerable.Empty<AddressDto>();
                }
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AddressDto>();
            }
        }
    }
}
