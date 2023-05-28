# Teste Vaga Dev Back-end na Houseasy
Repositório a fim de testar candidatos para vaga de Dev Back-end na Empresa https://houseasy.net/

| Para esta vaga, buscamos alguém apaixonado por desafios e atento aos detalhes!


  # Instruções a respeito do repositório
  
    1 - Faça um Fork deste repositório;
    2 - Ao terminar, atualize o README.md no seu repositório com as instruções de instalação e como executar o projeto;
    
    
  # Stack
    
    - C#
    
  # Desafio
  - Você deve fazer uma API utilizando a linguagem C# e framework .net 6.0.
    - Essa api deve conter um CRUD de:
      - Usuários
      - Endereços
      - Telefones
      - Ocupação
      
      Utilize boas praticas de programação.

 
# Principais requisitos:
    1 - Uso de Migrations;
    2 - Uso de MappingProfiles (DTO para response ou para request);
    3 - Uso de ContextAPI

 

Os diferenciais serão a utilização de técnicas do Clean Code, criação de documentação via sweagger ou postman e containerização do projeto.

                
           
   ## Final
                
    - Subir o repositório no seu Github e enviar o link com o assunto: Teste Dev. Backend para Carlos Henrique em carlos.souza@houseasy.net
     e no e-mail, informar do que se trata sua aplicação, com um breve resumo.
## Sobre o projeto

A api foi desenvolvida visando uma futura integração com alguma aplicação frontend ( por exemplo Reactjs, Angular ou Vue.js). Consiste no cadastro básico de um usuário e seus respectivos dados relacionados. Foram utilizados as ferramentas para desenvolvimento: Visual Studio 2022, Docker Desktop (windows), e Beekeeper (client SQL): <https://github.com/beekeeper-studio/beekeeper-studio/releases/tag/v3.9.14>

Abaixo segue diagrama idealizado para o projeto:
![image](https://github.com/Alex-cordeiro/imagerepo/blob/c529c4091416a953173a5c5f7f8714d445bd289e/houseeasy/diagrama_houseEasy.png)

A ideia da Api é que seja primeiramente cadastrado um usuário e com o registro em banco seja possível adicionar as informações atreladas à ele, as cardinalidades entre as entidades são:

- Um usuário pode ter um e somente um endereço
- Um usuário pode ter um e somente um registro de telefone (Esse registro contém um numero de telefone fixo, um telefone de celular e uma flag referenciando se o numero de celular possui WhatsApp.)
- Um usuário pode ter no mínimo uma e no máximo várias Ocupações (as ocupações foram idealizadas para conter os registros de ocupações de acordo com a  ***CBO - Classificação Brasileira de Ocupações*** , utilizando o código padronizado como CBO-2002). Para base segue link da plataforma da pravaler onde os dados foram obtidos: <https://www.pravaler.com.br/consulta-cbo-online/>

Segue link da documentação feita pelo postman com alguns exemplos para registro na base: https://documenter.getpostman.com/view/10110604/2s93m7Wgu7#0634eac2-1d00-4023-bd76-c749ee924ba3

##Instruções de Instalação

Seguem os passos para obter o projeto e rodá-lo localmente:

***Requisitos:***
Possuir o Ef Core CLI instalado: <https://learn.microsoft.com/pt-br/ef/core/cli/dotnet>
Possuir o Docker Desktop Instalado: https://www.docker.com/products/docker-desktop/
Por ultimo e não menos importante, possuir a SDK do .net 6.0 instalado: https://dotnet.microsoft.com/en-us/download/dotnet/6.0
                
1. Realizar o Clone do projeto em: https://github.com/Alex-cordeiro/houseasy-teste-backend.git 

2. O projeto pode ser iniciado via Visual Studio ou VisualStudio Code (desde que instalado as ferramentas CLI do EF Core)
 + ***Via Visual Studio:***
    + Abrir o visual studio e selecionar Abrir Projeto ou Solução.
    + Com a solução aberta, verificar se no dropdown de startup projects se está habilitado para rodar via docker compose. Caso estiver clicar no botão do lado direito com o simbolo de Play:
	![image](https://github.com/Alex-cordeiro/imagerepo/blob/20b1aedec44e60259887d2de44225bc10b4f677e/houseeasy/start_project_docker.png)
  
	+ Após isso o visual studio vai iniciar o processo de build das imagens, e assim que a aplicação, o banco de dados e as migrations subirem a página do swagger vai aparecer indicando que a aplicação está pronta para receber requisições.


 + Via Visual Studio Code ou Power Shell 
 	+ Abrir a pasta raiz da aplicação
	+ abrir uma janela de Power Shell onde fica do arquivo Docker-Compose.yml
	+ rodar o comando docker-compose up
	+ o docker então vai iniciar o processo de build das imagens e assim que a aplicação e o banco de dados subirem a página do swagger vai aparecer indicando que a aplicação está pronta para receber requisições.
	
## Bibliotecas utilizadas no projeto

 - Ef Core 6.0.12
 - AutoMapper: 12.0.1
 
 ### Pontos finais
 
O projeto foi inicialmente pensado para funcionar utilizando o banco local SQLite para facilitar sua avaliação. Porém como havia a possíbilidade de habilitar a conteinerização da aplicação, optou-se pela utilização do SQL Server da microsoft para facilitar o acesso aos dados e operações nas tabelas por parte do avaliador do teste, e também possibilitar que as migrations fossem aplicadas automaticamente no momento de inicialização da aplicação.
