using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Campeonato;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CampeonatoService : ICampeonatoService
    {

        private IRepository<CampeonatoEntity> _repository;
        public CampeonatoService(IRepository<CampeonatoEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CampeonatoEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<CampeonatoEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<CampeonatoEntity> Post(CampeonatoEntity campeonato)
        {
            return await _repository.InsertAsync(campeonato);
        }

        public async Task<CampeonatoEntity> Put(CampeonatoEntity campeonato)
        {
            return await _repository.UpdatetAsync(campeonato);
        }
    }
}
