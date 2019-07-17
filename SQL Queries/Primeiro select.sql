/* SELECT * FROM SacolaDaCooper */

/* select SacolaDaCooper.CaixaCafe as 'Kg de Café',
		Leite 'Kg de Leite'
from SacolaDaCooper; */

/* select Acucar +
	   CaixaCafe +
	   CervejaBarril +
	   CervejaLata +
	   CervejaLitrao +
	   CervejaLong +
	   Eno +
	   KilosCarne +
	   Leite +
	   Pinga as 'Limite de peso'
from SacolaDaCooper; */

/* select Id,
	   Leite,
	   CaixaCafe
from SacolaDaCooper
where id = 1 */

/* insert into SacolaDaCooper
(CaixaCafe, Leite)
values
(10, 3);
go
select * from SacolaDaCooper; */

/* select * from SacolaDaCooper
where Acucar is null
	and CaixaCafe > 0 */

/* update SacolaDaCooper
set Acucar = 0;
go
select * from SacolaDaCooper; */

/* delete SacolaDaCooper;
go
select * from SacolaDaCooper; */

delete SacolaDaCooper
where CaixaCafe > 53
	or CervejaLong > 13
go
select * from SacolaDaCooper