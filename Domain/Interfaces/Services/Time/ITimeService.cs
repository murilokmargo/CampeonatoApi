using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Time
{
    public interface ITimeService
    {
        Task<TimeDtoCreate> Get(Guid id);
        Task<IEnumerable<TimeDTOCreateResult>> GetAll();
        Task<TimeDTOCreateResult> Post(TimeDtoCreate time);
        Task<TimeDtoUpdateResult> Put(TimeDtoUpdate time);
        Task<bool> Delete(Guid id);
    }
}
