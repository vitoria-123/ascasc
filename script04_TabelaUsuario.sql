BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Usuarios]') AND [c].[name] = N'Perfil');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Usuarios] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Usuarios] ADD DEFAULT N'Jogador' FOR [Perfil];
GO

ALTER TABLE [Personagens] ADD [FotoPersonagem] varbinary(max) NULL;
GO

ALTER TABLE [Personagens] ADD [UsuarioId] int NULL;
GO

CREATE TABLE [TB_Disputas] (
    [Id] int NOT NULL IDENTITY,
    [Dt_Disputa] datetime2 NULL,
    [AtacanteId] int NOT NULL,
    [OponenteId] int NOT NULL,
    [Tx_Narracao] nvarchar(max) NULL,
    CONSTRAINT [PK_TB_Disputas] PRIMARY KEY ([Id])
);
GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Personagens] SET [FotoPersonagem] = NULL, [UsuarioId] = NULL
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [Usuarios] SET [PasswordHash] = 0x809E9AC835622931B157EC14328AA8E8948CF4FE263935D74C8B2F9CAE933E4E418F11920E7996EBD5F722ADB96291B3837D92B87FD5C21FD678E38A3CA2485F, [PasswordSalt] = 0x6D3713EC8ABD7B5D97CD38193DB96276DFDA5394577F41BEB085F549BBE9A3669779EEC98D5A8BE288E6DEE99EBCF202468334C512622B69F3454AD774FB35349A5836C7AD18C58FB6A7FAEF742504FC4297614C2B7CC457C65468BCB48C73EE0DF43C8A5B13BA5E4FE2093B43A9ECC2924164AF3D962CF17BB47611E80C30B3
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_Personagens_UsuarioId] ON [Personagens] ([UsuarioId]);
GO

ALTER TABLE [Personagens] ADD CONSTRAINT [FK_Personagens_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230731121007_MigracaoUsuario', N'7.0.4');
GO

COMMIT;
GO

