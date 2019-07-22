CREATE TABLE [dbo].[Carros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Modelo] VARCHAR(50) NOT NULL,
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_Carros_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Carros_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)