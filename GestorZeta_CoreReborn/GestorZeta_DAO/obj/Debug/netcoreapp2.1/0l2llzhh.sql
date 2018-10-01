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
    [RazaoSocial] nvarchar(max) NULL,
    [Fantasia] nvarchar(max) NULL,
    CONSTRAINT [PK_ENTIDADE] PRIMARY KEY ([ID_ENTIDADE])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180928190757_Inicial', N'2.1.3-rtm-32065');

GO

