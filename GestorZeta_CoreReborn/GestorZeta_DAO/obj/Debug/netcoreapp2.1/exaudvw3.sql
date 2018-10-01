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
    [ID_ENTIDADE_TRANSP] int NULL,
    [ID_FORMA_PGTO] int NULL,
    [ID_SEG_MERCADO] int NULL,
    [ID_CRT] int NULL,
    [DATA_ULT_ALT] datetime NULL,
    [HORA_ULT_ALT] datetime NOT NULL,
    [USUARIO_ULT_ALT] nvarchar(120) NULL,
    [DATA_CADASTRO] datetime NOT NULL,
    [USUARIO_CADASTRO] nvarchar(120) NOT NULL,
    [OBS] nvarchar(max) NULL,
    [EXCLUIDO] bit NOT NULL,
    [RazaoSocial] nvarchar(max) NULL,
    [Fantasia] nvarchar(max) NULL,
    CONSTRAINT [PK_ENTIDADE] PRIMARY KEY ([ID_ENTIDADE])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181001175837_Inicial', N'2.1.3-rtm-32065');

GO

