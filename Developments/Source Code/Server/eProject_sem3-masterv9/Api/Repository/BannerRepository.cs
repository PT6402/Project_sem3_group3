using Api.Data_helper;
using Api.Interface.IRepo;
using AutoMapper;
using Lib.Dto;
using Lib.Dto.Banner;
using Lib.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class BannerRepository : IBannerRepository
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public BannerRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<DtoResult<BannerDto>> Create([FromForm] BannerDto model, IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return new DtoResult<BannerDto>
                    {
                        Status = false,
                        Message = "Please provide a valid file"
                    };
                }

                string uploadsFolder = Path.Combine("Service", "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                model.Path = uniqueFileName;

                var banner = new Banner
                {
                    Path = model.Path
                };

                _db.Banner.Add(banner);
                await _db.SaveChangesAsync();

                return new DtoResult<BannerDto>
                {
                    Status = true,
                    Message = "Create successfully"
                };
            }
            catch (Exception ex)
            {
                return new DtoResult<BannerDto>
                {
                    Status = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<DtoResult<BannerDto>> Delete(int id)
        {
            try
            {
                var model = await _db.Banner.FirstOrDefaultAsync(b => b.Id == id);
                if(model != null)
                {
                    _db.Remove(model);
                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = false,
                        Message = "Delete successfully"
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

        public async Task<IEnumerable<BannerDto>> GetAll()
        {
            var list = await _db.Banner.ToListAsync();
            var res = new List<BannerDto>();
            foreach (var item in list)
            {
                res.Add(_mapper.Map<BannerDto>(item));
            }
            return res;
        }

        public async Task<DtoResult<BannerDto>> Update(BannerDto model)
        {
            try
            {
                var banner = await _db.Banner.FirstOrDefaultAsync(b => b.Id.Equals(model.Id));
                if (banner != null)
                {
                    banner.Path = model.Path;
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
    }
}
