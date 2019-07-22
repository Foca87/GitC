CREATE TABLE [dbo].[Estoque]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Modelo] INT NOT NULL,
	[Placa] VARCHAR(10) NOT NULL,
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT [FK_Estoque_Carros] FOREIGN KEY ([Modelo]) REFERENCES [Carros]([Id]),
    CONSTRAINT [FK_Estoque_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Estoque_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)