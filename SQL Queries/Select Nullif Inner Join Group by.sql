select 
	AL.Nome,
	TU.Materia,
	BO.DataAula,
	BO.Presenca,
	BO.Nota
from Aluno AL
inner join Boletim BO on BO.Aluno = AL.Id
inner join Turma TU on TU.Id = BO.Turma

select 
	AL.Nome,
	TU.Materia,
	(SUM(BO.Nota) / COUNT(BO.Nota)) as 'Média',
	((COUNT(NULLIF(BO.Presenca,0)) * 100) / COUNT(BO.DataAula)) as 'Presença %',
	IIF(SUM(BO.Nota) / COUNT(BO.Nota) >= 7, 'Aprovado', 'Reprovado'),
	IIF((COUNT(NULLIF(BO.Presenca,0)) * 100) / COUNT(BO.DataAula) >= 75, 'Aprovado', 'Reprovado'),
	IIF((SUM(BO.Nota) / COUNT(BO.Nota) >= 7) and (COUNT(NULLIF(BO.Presenca,0)) / COUNT(BO.DataAula) >= 0.75), 'Aprovado', 'Reprovado') as 'Status'
from Aluno AL
inner join Boletim BO on BO.Aluno = AL.Id
inner join Turma TU on TU.Id = BO.Turma
group by AL.Nome, TU.Materia