using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    //Lógica de consulta
    public class CampeonatoRepository : ICampeonatoRepository
    {
        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CampeonatoEntity> InsertAsync(CampeonatoEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<CampeonatoEntity> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CampeonatoEntity>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CampeonatoEntity> UpdatetAsync(CampeonatoEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
