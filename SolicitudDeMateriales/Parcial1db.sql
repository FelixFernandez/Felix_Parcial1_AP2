create table Materiales(
MaterialesId int Primary key identity(1,1),
Razon varchar(50)
);

Create table MaterialesDetalles(
MaterialesDetallesId int primary key identity(1,1),
MaterialesId int Primary key identity(1,1),
TiposMateriales varchar(50),
Cantidad int
);