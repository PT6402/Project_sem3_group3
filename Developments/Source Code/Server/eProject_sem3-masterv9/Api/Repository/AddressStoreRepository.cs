using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Address;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
	public class AddressStoreRepository:IAddressStore
	{
		private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
		public AddressStoreRepository(DatabaseContext db, IMapper mapper)
		{
			_db = db;
            _mapper = mapper;
		}

		public async Task<List<AddressDto>>GetAddress_Stores()
		{
			var list = await _db.Address_stores.Include(x=>x.Addresses).ToListAsync();
            
            var res = new List<AddressDto>();
			foreach (var address in list) {
                res.Add(_mapper.Map<AddressDto>(address.Addresses));
            }
			return res;
		}

		public async Task<string>Create(AddressDto model)
		{
			try
			{
				Addresses newAddress = new()
				{
					Address_full = model.Address_full,
					Phone_code = model.Phone_code,
					Province_code = model.Province_code,
					District_code = model.District_code,
					Ward_code = model.Ward_code
				};
				_db.Address.Add(newAddress);
				await _db.SaveChangesAsync();

				Address_store newAddressStore = new()
				{
					Address_Id = newAddress.Id,
				};
				_db.Address_stores.Add(newAddressStore);
				await _db.SaveChangesAsync();
				return "true";
			}catch(Exception ex)
			{
				return ex.ToString();
			}
			
        }

        public async Task<DtoResult<AddressStoreDto>> Delete(int id)
        {
            try
            {
                var addst = await _db.Address_stores.FirstOrDefaultAsync(a => a.Id.Equals(id));
                if (addst != null)
                {
                    _db.Address_stores.Remove(addst);
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

        public async Task<DtoResult<AddressDto>> Edit(AddressDto model)
        {
            try
            {
                var addst = await _db.Address_stores.FirstOrDefaultAsync(a => a.Id.Equals(model.Id));
                var add = await _db.Address.FirstOrDefaultAsync(x => x.Id.Equals(addst!.Address_Id));
                if (addst != null)
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
                Console.WriteLine(ex.InnerException?.Message);
                return new()
                {
                    Status = false,
                    Message = ex.InnerException?.Message
                };
            }
        }

        public async Task<IEnumerable<AddressDto>> GetStore(AddressStoreSearch model)
        {
            try
            {
                var stores = await _db.Address_stores
               .Include(x => x.Addresses)
               .Where(x => x.Addresses!.Province_code == model.Province_code
                && x.Addresses!.District_code == model.District_code)
               .ToListAsync();

                var res = new List<AddressDto>();
                foreach (var store in stores)
                {
                    res.Add(_mapper.Map<AddressDto>(store.Addresses));
                }
                return res;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AddressDto>();
            }
        }

    }
}

