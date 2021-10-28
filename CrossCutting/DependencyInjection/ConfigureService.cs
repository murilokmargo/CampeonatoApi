using Domain.Interfaces.Services.Campeonato;
using Domain.Interfaces.Services.Partida;
using Domain.Interfaces.Services.Time;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITimeService, TimeService> ();
            serviceCollection.AddTransient<IPartidaService, PartidaService>();
            serviceCollection.AddTransient<ICampeonatoService, CampeonatoService>();
        }
    }
}
