Select Nome from Marcas where UsuInc = 1;
Select Nome from Marcas where UsuInc = 2;
GO
select count(id) as 'Quantidade de Marcas registradas Decrescente' from Marcas where UsuInc = 1 order by [Quantidade de Marcas registradas Decrescente] desc;
select count(id) as 'Quantidade de Marcas registradas Crescente' from Marcas where UsuInc = 2 order by [Quantidade de Marcas registradas Crescente] asc;
GO
select count(id) as 'Quantidade de Marcas registradas pelo Felipe e Giomar' from Marcas where (UsuInc = 1 or UsuInc = 2);
GO
Select Modelo from Carros where UsuInc = 1;
Select Modelo from Carros where UsuInc = 2;
GO
select count(id) as 'Quantidade de Carros registrados Decrescente' from Carros where UsuInc = 1 order by [Quantidade de Carros registrados Decrescente] desc;
select count(id) as 'Quantidade de Carros registrados Crescente' from Carros where UsuInc = 2 order by [Quantidade de Carros registrados Crescente] asc;
GO
select count(id) as 'Quantidade de Carros registrados pelo Felipe e Giomar' from Carros where (UsuInc = 1 or UsuInc = 2);
GO
select ca.Modelo from Carros ca inner join Marcas ma on ca.Marca = ma.Id where ma.UsuInc = 1;
select ca.Modelo from Carros ca inner join Marcas ma on ca.Marca = ma.Id where ma.UsuInc = 2;
GO
select count(ca.Modelo) as 'Quantidade' from Carros ca inner join Marcas ma on ca.Marca = ma.Id where ma.UsuInc = 1 order by Quantidade desc;
select count(ca.Modelo) as 'Quantidade' from Carros ca inner join Marcas ma on ca.Marca = ma.Id where ma.UsuInc = 2 order by Quantidade asc;
GO
select sum(Valor * Quantidade) as 'Valor Total de Vendas do ano' from Vendas where year(DatInc) = 2019;
select sum(Quantidade) as 'Quantidade Total de Vendas do ano' from Vendas where year(DatInc) = 2019;
GO
select sum(Valor * Quantidade) as 'Valor Total de Vendas por ano' from Vendas group by year(DatInc) order by [Valor Total de Vendas por ano] desc;
select sum(Quantidade) as 'Quantidade Total de Vendas por ano' from Vendas group by year(DatInc) order by [Quantidade Total de Vendas por ano] desc;
GO
select year(DatInc) as 'Ano', month(DatInc) as 'Mês', sum(Quantidade) as 'Quantidade de Vendas' from Vendas group by month(DatInc), year(DatInc) order by [Quantidade de Vendas] desc;
select year(DatInc) as 'Ano', month(DatInc) as 'Mês', sum(Valor * Quantidade) as 'Valor Total de Vendas' from Vendas group by month(DatInc), year(DatInc) order by [Valor Total de Vendas] desc;
GO
select sum(Valor * Quantidade) as 'Valor Total de Vendas' from Vendas where UsuInc = 1 order by [Valor Total de Vendas] desc;
select sum(Valor * Quantidade) as 'Valor Total de Vendas' from Vendas where UsuInc = 2 order by [Valor Total de Vendas] desc;
GO
select sum(Quantidade) as 'Quantidade Total de Vendas' from Vendas where UsuInc = 1 order by [Quantidade Total de Vendas] desc;
select sum(Quantidade) as 'Quantidade Total de Vendas' from Vendas where UsuInc = 2 order by [Quantidade Total de Vendas] desc;
GO
select sum(Quantidade) as 'Quantidade Total de Vendas' from Vendas where (UsuInc = 1 or UsuInc = 2) order by [Quantidade Total de Vendas] desc;
select sum(Valor * Quantidade) as 'Valor Total de Vendas' from Vendas where (UsuInc = 1 or UsuInc = 2) order by [Valor Total de Vendas] desc;
GO
select ma.Nome, sum(ve.Quantidade) as 'Vendas da Marca' from Vendas ve inner join Carros ca on ve.Carro = ca.Id inner join Marcas ma on ca.Marca = ma.Id group by ma.Nome order by [Vendas da Marca] desc;
select ma.Nome, sum(ve.Quantidade * ve.Valor) as 'Valor Total de Vendas da Marca' from Vendas ve inner join Carros ca on ve.Carro = ca.Id inner join Marcas ma on ca.Marca = ma.Id group by ma.Nome order by [Valor Total de Vendas da Marca] desc;
GO
select ca.Modelo, sum(ve.Quantidade) as 'Quantidade Vendida' from Carros ca inner join Vendas ve on ca.Id = ve.Carro group by ca.Modelo order by [Quantidade Vendida] desc;
select ca.Modelo, sum(ve.Quantidade * ve.Valor) as 'Valor Total de Vendas por carro' from Carros ca inner join Vendas ve on ca.Id = ve.Carro group by ca.Modelo order by [Valor Total de Vendas por carro] desc;