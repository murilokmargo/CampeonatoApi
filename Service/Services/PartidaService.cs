using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Partida;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PartidaService : IPartidaService
    {

        private IRepository<PartidaEntity> _repository;
        public PartidaService(IRepository<PartidaEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PartidaEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<PartidaEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<PartidaEntity> Post(PartidaEntity partida)
        {
            return await _repository.InsertAsync(partida);
        }

        public async Task<PartidaEntity> Put(PartidaEntity partida)
        {
            return await _repository.UpdatetAsync(partida);
        }
    }
}
