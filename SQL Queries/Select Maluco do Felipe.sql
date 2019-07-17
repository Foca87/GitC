select 'Carros' as 'Carros',
	SUM(Temp.Media) as 'Vendas',
	Temp.AnoVenda
from (select
			Modelo,
			AnoFabricacao,
			(SUM(NumeroVendas) / COUNT(*)) as 'Media',
			YEAR(DataVenda) as 'AnoVenda'
		from Locadora
		group by Modelo, AnoFabricacao, YEAR(DataVenda)) Temp
group by Temp.AnoVenda