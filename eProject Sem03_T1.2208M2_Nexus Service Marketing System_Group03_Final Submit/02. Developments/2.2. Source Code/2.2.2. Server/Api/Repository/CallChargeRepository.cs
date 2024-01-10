using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using Lib.Dto.CallCharge;
using Lib.Dto.Duration;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
	public class CallChargeRepository:ICallCharge
	{
        private readonly DatabaseContext _db;
        public CallChargeRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<Call_charges>> GetCall_Charges()
        {


            return await _db.Call_charges.ToListAsync();
        }
        public async Task<bool> Create(Call_charges model)
        {
            try
            {
                var callcharge = await _db.Call_charges.FirstOrDefaultAsync(x => x.Id == model.Id);
                if (callcharge != null)
                {
                    return false;
                }
                Call_charges newcall = new Call_charges()
                {
                    Name=model.Name,
                    Price=model.Price,
                    Unit=model.Unit
                };
                _db.Call_charges.Add(newcall);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                var callcharge = await _db.Call_charges.FirstOrDefaultAsync(x => x.Id == id);
                if (callcharge != null)
                {
                    _db.Call_charges.Remove(callcharge);
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

        public async Task<bool> Update(int id, CallChargeDto model)
        {
            try
            {
                var existdu = await _db.Call_charges.FirstOrDefaultAsync(x => x.Id == id);
                if (existdu != null)
                {
                    existdu.Name = model.Name;
                    existdu.Unit = model.Unit;
                    existdu.Price = model.Price;

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
    }
}

