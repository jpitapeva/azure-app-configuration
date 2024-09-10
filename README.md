## Projeto WebApi com dotnet8

# Recurso Azure App Configuration

O gerenciamento de configurações em aplicações costuma demandar uma parcela de tempo significativa, sendo que em muitas ocasiões os profissionais envolvidos não fazem uso de uma solução que facilite este tipo de trabalho. Como consequências desta lacuna teremos eventuais erros em ambientes de Produção, com as dificuldades aumentando consideravelmente conforme cresce o número de projetos envolvidos.

Outro ponto importante diz respeito a modificações em configurações. Em muitas situações isto implica na necessidade de reiniciar a aplicação em execução, resultando assim em indisponibilidade, eventuais prejuízos e reclamações por parte dos usuários afetados.

E se pudéssemos utilizar uma alternativa que simplifique o gerenciamento de configurações, além de evitar o restart de uma ou mais aplicações caso alguma definição deste tipo precise passar por uma alteração?

Uma resposta a essas questões está uma opção disponibilizada recentemente no Microsoft Azure: trata-se do App Configuration. Com suporte a .NET Core/ASP.NET Core, .NET Full/ASP.NET e Java (Spring), essa alternativa oferece ainda a possibilidade de integração via REST API.




## Testar
Efetuar chamadas GET no link: `https://localhost:5002/v1/appconfigurations`
</br>
Método get(ExemploAppConfigurationsController), path `src/AppConfigurations.WebApi/Controllers/AppConfigurationsController.cs`

## Créditos @renatogroffe
https://renatogroffe.medium.com/asp-net-core-azure-app-configuration-manipulando-configura%C3%A7%C3%B5es-de-forma-mais-inteligente-52f65fc5fe19
