select * from Biblioteca BL
	inner join Livro LV on BL.Id = LV.Biblioteca

select 
	LV.Id,
	LV.Nome,
	IIF(LV.Alocado = 1, 'Sim', 'Não') as 'Alocado',
	BL.Nome as 'Nome da Biblioteca'
from Biblioteca BL
inner join Livro LV on BL.Id = LV.Biblioteca

select 
	BL.Nome,
	COUNT(LV.Id) as 'Quantidade de Livros'
from Biblioteca BL
inner join Livro LV on BL.Id = LV.Biblioteca
group by BL.Nome

select 
	BL.Nome,
	COUNT(LV.Id) as 'Quantidade de Livros',
	US.Nome as 'Username'
from Biblioteca BL
inner join Livro LV on BL.Id = LV.Biblioteca
inner join Usuario US on LV.UsuInc = US.Id
group by BL.Nome, US.Nome