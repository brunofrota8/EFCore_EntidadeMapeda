# EFCore_EntidadeMapeda
Entidade do Gestor Zeta Inteiramente Mapeada com o EF Core

Instalando o Entity
	Install-Package Microsoft.EntityFrameworkCore.SqlServer

Instalando o Tools para Utilizar o Migration
	Install-Package Microsoft.EntityFrameworkCore.Tools
	
	Comandos:
		Add-Migration
    Drop-Database
    Get-DbContext
    Remove-Migration
    Scaffold-DbContext
    Script-Migration
    Update-Database


Criar o DBContext

Passos para o Mapeamento da Tabela
	- Criar Classe (Referente a Tabela)
	- Criar o Contexto da Tabela
	- Criar o "Configuration" para o Mapeamento da Tabela (ModelBuilder) - Relacionar  Tipos de Dados
	- Criar o construtor no Contexto
	- Criar a Classe XPTODAO 

A Tabela Entidade Demorou umas 8 horas pelo menos para ser mapeada



