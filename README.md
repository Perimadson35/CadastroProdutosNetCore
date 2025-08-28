Guia do Sistema de Cadastro de Produtos e Clientes

1. O que foi feito no projeto
Este sistema é um protótipo de gerenciamento de produtos e clientes, desenvolvido com ASP.NET Core Razor Pages. As seguintes funcionalidades foram implementadas e configuradas:

Gerenciamento de Clientes (CRUD):

Criação de novos clientes com campos como Nome, Sobrenome, E-mail, Data de Cadastro e status Ativo.

Visualização de todos os clientes em uma tabela.

Edição de informações de clientes existentes.

Exclusão de clientes.

Gerenciamento de Produtos (CRUD):

Criação de novos produtos com campos como Nome, Valor, status Disponível e a vinculação a um cliente existente.

Visualização de todos os produtos em uma tabela.

Edição de produtos existentes, incluindo validação para o uso de vírgula no campo de valor.

Exclusão de produtos.

Melhorias na Interface do Usuário (UI):

Página Inicial (Home) funcional e com links diretos para as áreas de produtos e clientes.

Adição de colunas "Código" para identificar clientes e produtos de forma única nas tabelas.

Exibição do nome do cliente (em vez do ID) na tabela de produtos e na página de detalhes de um produto.

Indicadores visuais para os campos Ativo e Disponível, exibindo "Sim" em verde e "Não" em vermelho.

Aparência mais profissional para as tabelas com linhas zebradas e cabeçalho escuro.

2. Como executar o projeto
Para rodar este projeto em sua máquina, siga os passos abaixo:

Pré-requisitos
Certifique-se de que você tem o .NET SDK instalado em seu computador.

Passos de Execução
Abra o terminal
Abra o terminal (como o PowerShell, Prompt de Comando ou Terminal do VS Code) e navegue até a pasta raiz do projeto (CadastroProdutosNetCore).

Restaure as dependências
Execute o comando abaixo para garantir que todas as dependências do projeto foram baixadas corretamente.

Bash

dotnet restore
Execute a aplicação
Agora, rode a aplicação com o seguinte comando:

Bash

dotnet run
Acesse o sistema
Após a execução do comando, a aplicação estará no ar. Abra seu navegador e acesse o endereço:
http://localhost:5000

Seu sistema de gerenciamento de produtos e clientes estará pronto para ser utilizado!