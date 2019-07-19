CREATE TABLE [dbo].[Boletim]
( 
    [Aluno] INT NOT NULL, 
    [Turma] INT NOT NULL, 
    [Nota] INT NOT NULL, 
    [DataAula] DATE NOT NULL, 
    [Presenca] BIT NOT NULL, 
    CONSTRAINT [FK_Boletim_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [Aluno]([Id]), 
    CONSTRAINT [FK_Boletim_Turma] FOREIGN KEY ([Turma]) REFERENCES [Turma]([Id])
)