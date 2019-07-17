--Select que reúne o total de vendas de um determinado produto por mês.

select
	Tipo,
	MONTH(DataVenda) as 'Mês da Venda',
	SUM(TotalVendas) as 'Total do Mês'
from FoodTruckZezinho
group by Tipo, MONTH(DataVenda)
order by [Total do Mês] desc