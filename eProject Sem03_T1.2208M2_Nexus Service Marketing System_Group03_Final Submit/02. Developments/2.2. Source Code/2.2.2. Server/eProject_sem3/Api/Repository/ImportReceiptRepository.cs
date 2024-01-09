using System.Collections.Generic;
using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Product.Ctrl;
using Lib.Dto.Stories;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class ImportReceiptRepository : IImportReceiptRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public ImportReceiptRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        //Create
        public async Task<DtoResult<StoriesDto>> Create(StoriesReq model)
        {
            try
            {
                var storage = await _db.Address_stores.FirstOrDefaultAsync(
                    s => s.Id == model.addressStore_id);

                ImportReceipt newS = new ImportReceipt()
                {
                    Product_Id = model.Product_id,
                    Quantity = model.Quantity_product,
                    Time = DateTime.Now,
                    Status = "Done",
                    Storage_id = storage!.Id
                };
                _db.ImportReceipt.Add(newS);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create Stories Successfully!"
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

        public async Task<DtoResult<StoriesDto>> DeleteStories(int id)
        {
            try
            {
                var res = await _db.ImportReceipt.FirstOrDefaultAsync(p => p.Id.Equals(id));
                if (res != null)
                {
                    _db.ImportReceipt.Remove(res);
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Delete successfully!"
                    };
                }
                else
                {
                    return new()
                    {
                        Status = false,
                        Message = "Delete fail"
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

        public async Task<DtoResult<StoriesDto>> Edit(StorageRequest model)
        {
            try
            {
                var storage = await _db.Storages.FirstOrDefaultAsync(
                         s => s.Address_store_id == model.addressStore_id);
                var res = await _db.ImportReceipt.FirstOrDefaultAsync(
                    p => p.Product_Id.Equals(model.Product_id) && p.Storage_id == storage.Id);

                if (res != null && storage != null)
                {
                    res.Quantity = res.Quantity + model.Quantity_product;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully"
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

        public async Task<IEnumerable<StoriesDto>> GetAll()
        {
            var strList = await _db.ImportReceipt.ToListAsync();
            var res = strList.Select(p => new StoriesDto
            {
                Id = p.Id,
                Product_id = p.Product_Id,
                Quantity_product = p.Quantity,
                Time = p.Time,
                Status = p.Status,
                Storage_id = p.Storage_id
            }).ToList();

            return res;
        }

        public async Task<IEnumerable<StoriesRes>> GetProductByAddressStore(int address_store_id)
        {
            var strList = await _db.Storages.FirstOrDefaultAsync(
                s => s.Address_store_id == address_store_id);
            var Import = await _db.ImportReceipt.Where(a => a.Storage_id == strList!.Id).ToListAsync();

            var result = new List<StoriesRes>();

            foreach (var item in Import)
            {
                var product = await _db.Products
                .FirstOrDefaultAsync(p => p.Id == item.Product_Id);
                if (product != null)
                {
                    var storiesRes = new StoriesRes
                    {
                        id = product.Id,
                        name = product.Name,
                        numb_connect = product.Numb_Connect,
                        quantity = item.Quantity,
                        connect_type_id = product.Connect_type_Id,
                        supplier_id = product.Supplier_Id
                    };
                    result.Add(storiesRes);
                }
            }
            return result;
        }

        public async Task<IEnumerable<StoriesDto>> GetByTime(DateTime time)
        {
            var strList = await _db.ImportReceipt.Where(
                p => p.Time.Equals(time)).ToListAsync();
            var res = strList.Select(p => new StoriesDto
            {
                Id = p.Id,
                Product_id = p.Product_Id,
                Quantity_product = p.Quantity,
                Time = p.Time,
                Status = p.Status,
                //Storage_id = p.Storage_id
            }).ToList();

            return res;
        }

        public async Task<DtoResult<StoriesDto>> ExportProduct(StoriesReq model)
        {
            try
            {
                var storage = await _db.Address_stores.FirstOrDefaultAsync(
                    s => s.Id == model.addressStore_id);
                var res = await _db.ImportReceipt.FirstOrDefaultAsync(
                    p => p.Product_Id.Equals(model.Product_id));

                if (res != null && storage != null)
                {
                    res.Quantity = res.Quantity - 1;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully"
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

        public async Task<DtoResult<List<ProductDto>>> checkNotPro(int Address_Store_Id)
        {

            try
            {
                var storage = await _db.Storages.FirstOrDefaultAsync(x => x.Address_store_id == Address_Store_Id);
                var imre = await _db.ImportReceipt.Where(x => x.Storage_id == storage.Id).Select(o => o.Product_Id).ToListAsync();
                var pronot = await _db.Products.Where(p => !imre.Contains(p.Id)).ToListAsync();
                var pronotlist = pronot.Select(p => _mapper.Map<ProductDto>(p)).ToList();
                return new()
                {
                    Status = true,
                    Model = pronotlist
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
