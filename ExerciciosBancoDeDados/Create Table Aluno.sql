﻿CREATE TABLE [dbo].[Aluno]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Ativo] BIT NOT NULL DEFAULT 1, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE()
)
