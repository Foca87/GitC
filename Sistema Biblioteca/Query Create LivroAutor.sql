CREATE TABLE [dbo].[LivroAutor]
(
    [Livro] INT NOT NULL, 
    [Autor] INT NOT NULL, 
    CONSTRAINT [FK_LivroAutor_To_Livros] FOREIGN KEY ([Livro]) REFERENCES [Livros]([Id]),
	CONSTRAINT [FK_LivroAutor_To_Autores] FOREIGN KEY ([Autor]) REFERENCES [Autores]([Id])
)
