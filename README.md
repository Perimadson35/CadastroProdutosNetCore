🚀 Sistema de Cadastro de Produtos e Clientes
<br>
---
<br>
🌟 Sobre o Projeto
Este projeto é um protótipo de um sistema CRUD (Create, Read, Update, Delete) completo para Cadastro de Produtos e Clientes, desenvolvido utilizando ASP.NET Core Razor Pages. O objetivo foi construir uma aplicação web robusta e funcional, focando na organização do código, boas práticas de desenvolvimento e uma experiência de usuário intuitiva.
<br>
O sistema permite gerenciar clientes e seus respectivos produtos, demonstrando a capacidade de construir aplicações de back-end com uma interface web interativa.
<br>
<br>
✨ Funcionalidades Implementadas
As principais funcionalidades e melhorias desenvolvidas incluem:
<br>
<br>
👤 Gerenciamento de Clientes:
<br>
➕ Criar: Cadastro de novos clientes com Nome, Sobrenome, E-mail, Data de Cadastro e status Ativo.

📋 Listar: Visualização de todos os clientes em uma tabela com colunas personalizadas (Código, E-mail, Data/Hora/Cadastro).

✏️ Editar: Atualização das informações de clientes existentes.

🔍 Detalhes: Visualização detalhada de um cliente específico.

🗑️ Excluir: Remoção de clientes da base de dados.
<br>
<br>
📦 Gerenciamento de Produtos:
<br>
➕ Criar: Cadastro de novos produtos com Nome, Valor, status Disponível e vinculação a um cliente existente.

📋 Listar: Visualização de todos os produtos em uma tabela, incluindo o Nome do Cliente e seu codigoid relacionado.

✏️ Editar: Atualização das informações de produtos, com validação aprimorada para aceitar vírgulas em valores decimais.

🔍 Detalhes: Visualização detalhada de um produto específico, exibindo o nome do cliente associado.

🗑️ Excluir: Remoção de produtos da base de dados.
<br>
<br>

🎨 Melhorias na Interface (UI/UX):
🏠 Página Inicial (Home): Uma landing page acolhedora com links diretos para as seções de Clientes e Produtos.

🚦 Indicadores Visuais: Campos Ativo (Clientes) e Disponível (Produtos) são exibidos como "Sim" (✅ Verde) ou "Não" (❌ Vermelho) para maior clareza.

📊 Tabelas Aprimoradas:

Estilo: Utilização de table-striped (linhas zebradas) e table-hover (efeito ao passar o mouse) para melhor legibilidade.

Cabeçalho: table-dark para destacar o cabeçalho das tabelas.

Validação Frontend: Suporte para separadores decimais (vírgula e ponto) no campo de Valor dos produtos.
<br>
---
<br>
<br>
🛠️ Tecnologias Utilizadas
Backend:

.NET 7.0 (ou versão compatível)

C#

ASP.NET Core Razor Pages

Entity Framework Core (utilizado para simular o acesso a dados)

Frontend:

HTML5

CSS3

JavaScript

Bootstrap 5 (para estilização e responsividade)
<br>
---
<br>
<br>

🚀 Como Executar o Projeto Localmente
Siga estes passos para ter o projeto funcionando em sua máquina:
<br>
Pré-requisitos
.NET SDK 7.0 (ou versão compatível) instalado.

Um editor de código como Visual Studio Code ou Visual Studio.
<br>
Instruções
Clone o Repositório:
<br>
Bash
git clone https://github.com/Perimadson35/CadastroProdutosNetCore.git
Navegue até a pasta do projeto:
<br>
Bash
cd CadastroProdutosNetCore
Restaure as dependências do .NET:
<br>
Bash
dotnet restore
Execute a aplicação:
<br>
Bash
dotnet run
<br>
<br>
Acesse no Navegador:
Abra seu navegador e acesse o endereço:
http://localhost:5000
<br>
<br>
<br>
🤝 Contribuições
Sinta-se à vontade para abrir issues ou pull requests se tiver sugestões de melhoria ou encontrar algum problema.
<br>
<br>
<br>
📄 Licença
Este projeto está licenciado sob a licença MIT.
<br>
<br>
<br>
Nome: Perimadson Araujo Machado.

LinkedIn: https://www.linkedin.com/in/perimadson-araujo/

GitHub: https://github.com/Perimadson35/
