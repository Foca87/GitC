select
	Tipo,
	SUM(TotalVendas) as 'Total Vendas',
	MONTH(DataVenda) as 'Mês'
from FoodTruckZezinho
where MONTH(DataVenda) BETWEEN 1 and 3
group by Tipo, MONTH(DataVenda)
order by [Total Vendas] desc