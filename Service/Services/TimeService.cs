using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Time;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;

namespace Service.Services
{
    public class TimeService : ITimeService
    {

        private IRepository<TimeEntity> _repository;

        private readonly IMapper _mapper;

        public TimeService(IRepository<TimeEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<TimeDtoCreate> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<TimeDtoCreate>(entity);
        }

        public async Task<TimesPaginated> GetAll(PaginationFilter filter)
        {
           
            var listEntity = await _repository.SelectAsync(filter);
            var dataQuantity = await _repository.CountAsync();
            var data = _mapper.Map<IEnumerable<TimeDTOCreateResult>>(listEntity);
            var result = new TimesPaginated(data, dataQuantity, filter.PageNumber, filter.PageSize);

            return result;
        }

        public async Task<TimeDTOCreateResult> Post(TimeDtoCreate time)
        {
            if (await _repository.HasTimeByName(time.Nome))
            {
                return null;
            }
            
            var model = _mapper.Map<TimeModel>(time);
            var entity = _mapper.Map<TimeEntity>(model);
            var result = await _repository.InsertAsync(entity);



            return _mapper.Map<TimeDTOCreateResult>(result);
        }

        public async Task<TimeDtoUpdateResult> Put (TimeDtoUpdate time)
        {
            var model = _mapper.Map<TimeModel>(time);
            var entity = _mapper.Map<TimeEntity>(model);
            var result = await _repository.UpdatetAsync(entity);

            return _mapper.Map<TimeDtoUpdateResult>(result);
        }
    }
}
