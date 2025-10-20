create table estados(
	id int not null identity(10, 1) primary key,
	estado varchar (55) not null,
	uf varchar (3),
	oPais varchar (55) not null
)