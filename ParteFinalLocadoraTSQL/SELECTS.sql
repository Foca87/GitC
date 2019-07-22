-- Apresenta o Modelo do carro e Quantidade de Locações do mesmo no Mês selecionado.
select
	ca.Modelo,
	COUNT(lo.Placa) as 'Locações no Mês'
	from Locacoes lo
	inner join Estoque es on lo.Placa = es.Id
	inner join Carros ca on es.Modelo = ca.Id
where MONTH(lo.DataLocacao) = 3					-- Informe o Mês de qual deseja gerar o relatório
	and YEAR(lo.DataLocacao) = 2019				-- Informe o Ano de qual deseja gerar o relatório
group by ca.Modelo
order by [Locações no Mês] desc
GO
-- Relatório que apresenta a quantidade de locações agrupando pelo modelo de carro.
-- Relatório de Locações Anual ordenando pelo carro mais locado.
select
	ca.Modelo,
	COUNT(lo.Placa) 'Locações por Ano'
	from Locacoes lo
	inner join Estoque es on lo.Placa = es.Id
	inner join Carros ca on es.Modelo = ca.Id
where MONTH(lo.DataLocacao) between 1 and 12	-- Informe aqui Mês de início e fim para o relatório.
	and YEAR(lo.DataLocacao) = 2019				-- Informe aqui o Ano para o relatório.
group by ca.Modelo
order by [Locações por Ano] desc
GO
-- Apresenta total de Locações de carros no Ano
select
	YEAR(lo.DataLocacao) as 'Ano',
	COUNT(lo.Placa) as 'Total de Locações do Ano'
	from Locacoes lo
	inner join Estoque es on lo.Placa = es.Id
	inner join Carros ca on es.Modelo = ca.Id
where MONTH(lo.DataLocacao) between 1 and 12	-- Informe aqui Mês de início e fim para o relatório.
	and YEAR(lo.DataLocacao) = 2019				-- Informe aqui o Ano para o relatório.
group by YEAR(lo.DataLocacao)