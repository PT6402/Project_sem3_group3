using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using Lib.Dto;
using Lib.Dto.Package;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
    public class PackageRepository : IPackage
    {
        private readonly DatabaseContext _db;
        public PackageRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<PackageDto>> GetPackages()
        {

            var list = await _db.Packages.Include(p => p.Durations)
                .Select(p => new PackageDto
                {
                    package_id = p.Id,
                    namePackage = p.Name,
                    connect_type_id = p.Connect_type_Id,
                    durations = p.Durations!.Select(package => new Durations { duration_id = package.Id }).ToList()
                }).ToListAsync();
            return list;
        }

        public async Task<DtoResult<PackageRes>> Create(PackageRes model)
        {
            try
            {
                var package = await _db.Packages.FirstOrDefaultAsync(x => x.Name == model.namePackage);
                if (package != null)
                {
                    return new()
                    {
                        Status = false,
                        Message = "already exists"
                    };
                }
                Package newconnect = new Package()
                {
                    Name = model.namePackage,
                    Connect_type_Id = model.connect_type_id
                };
                _db.Packages.Add(newconnect);
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
                var package = await _db.Packages.FirstOrDefaultAsync(x => x.Id == id);
                if (package != null)
                {
                    _db.Packages.Remove(package);
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

        public async Task<DtoResult<PackageEdit>> Update(PackageEdit model)
        {
            try
            {
                var existpack = await _db.Packages.FirstOrDefaultAsync(x => x.Id.Equals(model.package_id));
                if (existpack != null)
                {

                    existpack.Name = model.namePackage ?? existpack.Name;
                    //existpack.Connect_type_Id = model.Connect_type_Id;

                    await _db.SaveChangesAsync();
                    return new()
                    {
                        Status = true,
                        Message = "Update successfully"
                    };
                }
                return new()
                {
                    Status = false,
                    Message = "Update fail"
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

