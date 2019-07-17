UPDATE AulaCsharp
Set Aluno = 'Giomar',
	Idade = 52,
	Ativo = 1,
	DatAlt = GETDATE()
where Id = 5
go
select * from AulaCsharp

UPDATE AulaCsharp
Set Aluno = 'NovoNomeNovaVida'
	where Idade < 52
go
select * from AulaCsharp

select Aluno,
	   Idade,
	   IIF (Ativo = 1, 'Ativo', 'Inativo') as 'Status'
	from AulaCsharp
where Id in
	(select ID from AulaCsharp
		where Idade >30)
order by Idade asc