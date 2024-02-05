# Projeto que gera um token JWT para utilização de autenticação aplicacao.
## Como usar:
Para utilizar essa projeto, basta ter o .NET 7 e Visual Code/Visual Studio 2022.

## O Que é JWT?:
Jwt é conhecido como json web token e sua popularidade encontra-se em aplicações web como meio de envio de informações e autenticação entre serviços.

## Tour pelo projeto:
A Principio, vamos fazer nossa aplicação entender que ela deve utilizar um middleware de autenticação,
adicionamos no nosso arquivo Program.cs ou Startup.cs dependendo de que versão do .Net Core vc esta utilizando.

<img width="773" alt="image" src="https://github.com/emrehliug/dotnet-tokenJwt/assets/44777996/fcd5713d-8f97-411b-a528-d4f165e8e89f">
<img width="198" alt="image" src="https://github.com/emrehliug/dotnet-tokenJwt/assets/44777996/c87dc4b3-64b4-4841-94b0-c81167dca8ae">

-------------------------------------------------------------------------------------------------------------------------------------

Agora criamos um model para simularmos um login:

<img width="358" alt="image" src="https://github.com/emrehliug/dotnet-tokenJwt/assets/44777996/21a4ebf4-427d-4a3e-9ca0-8ea68ecf2268">

-------------------------------------------------------------------------------------------------------------------------------------

Agora adicionamos ao projeto uma indicação de injeção de dependecia para utilizarmos o IConfiguration na nossa controllerAPI:

<img width="477" alt="image" src="https://github.com/emrehliug/dotnet-tokenJwt/assets/44777996/1e84af79-b394-466e-b059-adaf1db5c010">

-------------------------------------------------------------------------------------------------------------------------------------

Criamos a nossa ApiController chamada TokenController, injetamos a dependencia do IConfiguration para o metodo ctor(construtor), adicionamos uma ActionResult Login() para receber nosso modelo de login e se valido chamar nosso metodo que vai gerar um token JWT para utilização dos serviços.

<img width="886" alt="image" src="https://github.com/emrehliug/dotnet-tokenJwt/assets/44777996/0dca4cb2-7e19-4b92-a10c-cd6812834ba6">






## Tecnologias utilizadas:

<div>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="80" /> 
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="80" />
</div>
