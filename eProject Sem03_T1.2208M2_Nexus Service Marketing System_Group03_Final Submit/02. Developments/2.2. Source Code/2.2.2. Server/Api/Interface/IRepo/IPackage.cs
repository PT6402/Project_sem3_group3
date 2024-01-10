using System;
using Lib.Dto;
using Lib.Dto.Package;
using Lib.Entities;

namespace Api.Interface.IRepo
{
	public interface IPackage
	{
        Task<List<PackageDto>> GetPackages();
        Task<DtoResult<PackageRes>> Create(PackageRes model);
        Task<bool> Remove(int id);
        Task<DtoResult<PackageEdit>> Update(PackageEdit model);
    }
}

