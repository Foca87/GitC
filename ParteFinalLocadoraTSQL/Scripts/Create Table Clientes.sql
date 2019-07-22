CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Clientes_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Clientes_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
