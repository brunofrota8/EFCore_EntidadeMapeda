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
    [ID_EMPRESA] int NULL DEFAULT 0,
    [ID_ENTIDADE_TRANSP] int NULL DEFAULT 0,
    [ID_FORMA_PGTO] int NULL DEFAULT 0,
    [ID_SEG_MERCADO] int NULL DEFAULT 0,
    [ID_CRT] int NULL DEFAULT 0,
    [DATA_ULT_ALT] datetime NULL,
    [HORA_ULT_ALT] datetime NULL,
    [USUARIO_ULT_ALT] nvarchar(120) NULL,
    [DATA_CADASTRO] datetime NULL,
    [USUARIO_CADASTRO] nvarchar(120) NULL,
    [OBS] nvarchar(max) NULL,
    [EXCLUIDO] bit NOT NULL DEFAULT 0,
    [RazaoSocial] nvarchar(120) NULL,
    [Fantasia] nvarchar(120) NULL,
    [CNPJ] nvarchar(30) NULL,
    [IE] nvarchar(30) NULL,
    [IE_SUBS] nvarchar(30) NULL,
    [Contribuinte_ICMS] bit NOT NULL DEFAULT 0,
    [Tipo_Fornecedor] bit NOT NULL DEFAULT 0,
    [Tipo_Funcionario] bit NOT NULL DEFAULT 0,
    [Tipo_Cliente] bit NOT NULL DEFAULT 0,
    [Data_Abertura] datetime NULL,
    [Inscr_Municipal] nvarchar(30) NULL,
    [CNAE] nvarchar(30) NULL,
    [Inscr_Suframa] real NOT NULL,
    CONSTRAINT [PK_ENTIDADE] PRIMARY KEY ([ID_ENTIDADE])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181001181211_Inicial', N'2.1.3-rtm-32065');

GO

