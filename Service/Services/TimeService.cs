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

        public async Task<IEnumerable<TimeDTOCreateResult>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<TimeDTOCreateResult>> (listEntity);
        }

        public async Task<TimeDTOCreateResult> Post(TimeDtoCreate time)
        {
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
