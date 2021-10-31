Api desenvolvida em C#, junto de EFcore, ASP.NET CORE 5, SQLServer e  Code first.

Utilizado arquitura em camadas, onde temos as camadas Application, Service, Domain, Data e CrossCutting. 

A camada Application contém a controller de Time e Campeonato(responsáveis sobre a requisição dos  usuários), como também o startup responsável pelas configurações iniciais do sistema.

A camada Service é responsável em concentrar a lógica das regras de negócio.

A camada Domain contém a implementação de classes/modelos(as quais serão mapeadas para o banco de dados), declaração de interfaces e DTOS.

A Camada Data é responsável pelo e manuseio dos dados, tanto do banco de dados quanto da busca das informações pela API.
Também é responsável pela criação do banco utilizando o Code First com as migrations.

A Camada CrossCutting tem como princípio conter funcionalidades que podem ser usadas em qualquer parte do código.

Para executar o projeto em sua máquina local, certifique-se de que esteja com o banco de dados SqlServer instalado e executando.

Altere as string de conexão dos arquivos em Data->Context->ContextFacotry.cs e CrossCutting->DependencyInjection->ConfigureRepository.cs.

Necessário a execução do comando 'dotnet ef database update' para a geração/atualização do banco de dados.
