CREATE TABLE [dbo].[Locacoes]
(
	[Cliente] INT NOT NULL, 
    [Placa] INT NOT NULL,
	[DataLocacao] DATE NOT NULL DEFAULT GETDATE(),
	[DataDevolucao] DATE NOT NULL DEFAULT GETDATE() + 7,
	[Ativo] BIT NOT NULL DEFAULT 1, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT [FK_Locacoes_Clientes] FOREIGN KEY ([Cliente]) REFERENCES [Clientes]([Id]),
	CONSTRAINT [FK_Locacoes_Estoque] FOREIGN KEY ([Placa]) REFERENCES [Estoque]([Id]),
    CONSTRAINT [FK_Locacoes_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
	CONSTRAINT [FK_Locacoes_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)