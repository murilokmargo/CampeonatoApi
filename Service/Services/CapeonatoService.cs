using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Campeonato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    //Lógica de negócio
    public class CampeonatoService : ICampeonatoService
    {

        private ICampeonatoRepository _repository;
        private readonly IRepository<TimeEntity> _timeRepository;

        public CampeonatoService(ICampeonatoRepository repository, IRepository<TimeEntity> timeRepository)
        {
            _repository = repository;
            _timeRepository = timeRepository;
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

        public async Task<CampeonatoDto> ObterCampeonato()
        {
            var listTimes = await _timeRepository.SelectAsync();

            var result = CalculaCampeonato(listTimes);


            return result;
        }

        private CampeonatoDto CalculaCampeonato(IEnumerable<TimeEntity> listTimes)
        {
            
            var listPartidasDto = new List<PartidaDto>();
            var campeonatoDto = new CampeonatoDto();
            var rng = new Random();
            var listPontos = new Dictionary<string, int>(listTimes.Select(t => new KeyValuePair<string, int>(t.Nome, 0)));


            for (int i = 0; i < listTimes.Count() - 1; i++)
            {

                for (int j = i + 1; j < listTimes.Count(); j++)
                {
                    var golTime1 = rng.Next(7);
                    var golTime2 = rng.Next(7);
                    var partida = new PartidaDto();
                    partida.Times = $"{listTimes.ElementAt(i).Nome} x {listTimes.ElementAt(j).Nome}";
                    partida.Resultado = $"{golTime1} x {golTime2}";
                    listPartidasDto.Add(partida);
                    if (golTime1 > golTime2)
                    {
                        listPontos[listTimes.ElementAt(i).Nome] += 3;
                    }
                    else if (golTime1 == golTime2)
                    {
                        listPontos[listTimes.ElementAt(i).Nome] += 1;
                        listPontos[listTimes.ElementAt(j).Nome] += 1;
                    }
                    else
                    {
                        listPontos[listTimes.ElementAt(j).Nome] += 3;
                    }
                }
            }

            campeonatoDto.Partidas = listPartidasDto;
            //checar campeão
             listPontos = listPontos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            campeonatoDto.Campeao = listPontos.ElementAt(0).Key;
            campeonatoDto.Vice = listPontos.ElementAt(1).Key; ;
            campeonatoDto.Terceiro = listPontos.ElementAt(2).Key; ;

            return campeonatoDto;
        }
    }
}
