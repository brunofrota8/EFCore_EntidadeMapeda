IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [ENTIDADE] (
    [ID_ENTIDADE] int NOT NULL IDENTITY,
    [ID_EMPRESA] int NOT NULL,
    [ID_ENTIDADE_TRANSP] int NOT NULL,
    [ID_FORMA_PGTO] int NOT NULL,
    [ID_SEG_MERCADO] int NOT NULL,
    [ID_CRT] int NOT NULL,
    [DATA_ULT_ALT] datetime2 NOT NULL,
    [HORA_ULT_ALT] datetime2 NOT NULL,
    [USUARIO_ULT_ALT] nvarchar(max) NULL,
    [DATA_CADASTRO] datetime2 NOT NULL,
    [USUARIO_CADASTRO] datetime2 NOT NULL,
    [OBS] nvarchar(max) NULL,
    [EXCLUIDO] bit NOT NULL,
    [RazaoSocial] nvarchar(max) NULL,
    [Fantasia] nvarchar(max) NULL,
    [CNPJ] nvarchar(max) NULL,
    [IE] nvarchar(max) NULL,
    [IE_SUBS] nvarchar(max) NULL,
    [Contribuinte_ICMS] bit NOT NULL,
    [Tipo_Fornecedor] bit NOT NULL,
    [Tipo_Funcionario] bit NOT NULL,
    [Tipo_Cliente] bit NOT NULL,
    [Data_Abertura] datetime2 NOT NULL,
    [Inscr_Municipal] nvarchar(max) NULL,
    [CNAE] nvarchar(max) NULL,
    [Inscr_Suframa] real NOT NULL,
    [Telefone] nvarchar(max) NULL,
    [Fax] nvarchar(max) NULL,
    [Email_NFe] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Site] nvarchar(max) NULL,
    [Bloqueado] bit NOT NULL,
    [Credito_Pre_Aprovado] real NOT NULL,
    [Comissao] real NOT NULL,
    CONSTRAINT [PK_ENTIDADE] PRIMARY KEY ([ID_ENTIDADE])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180928202606_Inicial', N'2.1.3-rtm-32065');

GO

