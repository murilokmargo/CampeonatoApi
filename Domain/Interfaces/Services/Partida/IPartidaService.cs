using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Partida
{
    public interface IPartidaService
    {
        Task<PartidaEntity> Get(Guid id);
        Task<IEnumerable<PartidaEntity>> GetAll();
        Task<PartidaEntity> Post(PartidaEntity partida);
        Task<PartidaEntity> Put(PartidaEntity partida);
        Task<bool> Delete(Guid id);
    }
}
