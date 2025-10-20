create table cidades(
	id int not null identity(10, 1) primary key,
	cidade varchar (55) not null,
	ddd varchar (4),
	oEstado varchar (55) not null
)