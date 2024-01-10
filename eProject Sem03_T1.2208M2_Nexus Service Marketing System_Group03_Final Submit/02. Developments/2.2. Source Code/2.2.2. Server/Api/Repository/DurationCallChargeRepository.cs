using System;
using Api.Data_helper;
using Api.Interface.IRepo;
using Lib.Dto.DurationDetail;
using Lib.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository
{
	public class DurationCallChargeRepository:IDurationCallCharge
	{
        private readonly DatabaseContext _db;
        public DurationCallChargeRepository(DatabaseContext db)
        {
            _db = db;
        }
        public async Task<List<Duration_callCharges>> GetDuration_CallCharges()
        {


            return await _db.Duration_callCharges.ToListAsync();
        }

        public async Task<bool> Create(Duration_callCharges model)
        {
            try
            {
                var duration = await _db.Duration_callCharges.FirstOrDefaultAsync(x => x.Id == model.Id);
                if (duration != null)
                {
                    return false;
                }
                Duration_callCharges newduration = new Duration_callCharges()
                {
                    Duration_Id = model.Duration_Id,
                    Call_charges_Id = model.Call_charges_Id
                };
                _db.Duration_callCharges.Add(newduration);
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
                var duration = await _db.Duration_callCharges.FirstOrDefaultAsync(x => x.Id == id);
                if (duration != null)
                {
                    _db.Duration_callCharges.Remove(duration);
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

        public async Task<bool> Update(int id, DurationDetailDto model)
        {
            try
            {
                var existdu = await _db.Duration_callCharges.FirstOrDefaultAsync(x => x.Id == id);
                if (existdu != null)
                {
                    existdu.Duration_Id = model.Duration_Id;
                    existdu.Call_charges_Id = model.Call_ChargeId;

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

