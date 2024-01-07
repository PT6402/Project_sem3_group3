using Api.Data_helper;
using Api.Interface.IRepo;
using Lib.Dto;
using Lib.Dto.Product.Ctrl;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _db;
        public ProductRepository(DatabaseContext db)
        {
            _db = db;
        }

        //Create
        public async Task<DtoResult<ProductDto>> Create(ProductDto productDto)
        {
            try
            {
                var pro = await _db.Products.FirstOrDefaultAsync(
                    p => p.Name.Equals(productDto.name));
                if (pro != null)
                {
                    return new()
                    {
                        Status = false,
                        Message = "Product already exists"
                    };
                }
                Product newPro = new Product()
                {
                    Name = productDto.name,
                    Numb_Connect = productDto.numb_connect,
                    Connect_type_Id = productDto.connect_type_id,
                    Supplier_Id = productDto.supplier_id,
                };
                _db.Products.Add(newPro);
                await _db.SaveChangesAsync();
                return new()
                {
                    Status = true,
                    Message = "Create Product Successfully!"
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

        //Delete
        public async Task<DtoResult<ProductDto>> DeleteProduct(int id)
        {
            try
            {
                var pro = await _db.Products.FirstOrDefaultAsync(p => p.Id.Equals(id));
                if (pro != null)
                {
                    _db.Products.Remove(pro);
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

        //Edit
        public async Task<DtoResult<ProductDto>> Edit(ProductDto productDto)
        {
            try
            {
                var pro = await _db.Products.FirstOrDefaultAsync(
                    p => p.Id.Equals(productDto.id));

                if (pro != null)
                {
                    pro.Name = productDto.name;
                    pro.Numb_Connect = productDto.numb_connect;
                    pro.Connect_type_Id = productDto.connect_type_id;
                    pro.Supplier_Id = productDto.supplier_id;
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update Product successfully"
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

        //Get all
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var proList = await _db.Products.ToListAsync();
            var res = proList.Select(p => new ProductDto
            {
                id = p.Id,
                name = p.Name,
                numb_connect = p.Numb_Connect,
                connect_type_id = p.Connect_type_Id,
                supplier_id = p.Supplier_Id
            }).ToList();

            return res;
        }

        //Get by connect type
        public async Task<IEnumerable<ProductDto>> GetByConnectType(int id)
        {
            var proList = await _db.Products.Where(
                p => p.Connect_type_Id.Equals(id)).ToListAsync();
            var res = proList.Select(p => new ProductDto
            {
                id = p.Id,
                name = p.Name,
                numb_connect = p.Numb_Connect,
                connect_type_id = p.Connect_type_Id,
                supplier_id = p.Supplier_Id
            }).ToList();

            return res;
        }

        //Get by supplier
        public async Task<IEnumerable<ProductDto>> GetBySupplier(int id)
        {
            var proList = await _db.Products.Where(
                p => p.Supplier_Id.Equals(id)).ToListAsync();
            var res = proList.Select(p => new ProductDto
            {
                id = p.Id,
                name = p.Name,
                numb_connect = p.Numb_Connect,
                connect_type_id = p.Connect_type_Id,
                supplier_id = p.Supplier_Id
            }).ToList();

            return res;
        }
    }
}
