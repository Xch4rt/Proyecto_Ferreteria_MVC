create database Mantenimiento_Productos

use Mantenimiento_Productos

-- Creando Tablas: Categorias
create table Categoria(
	IdCategoria int identity (1,1) primary key not null,
	Codigo as ('CT'+RIGHT('00'+CONVERT(varchar, IdCategoria),(2))), -- formato CT01, CT02, CT03
	Nombre nvarchar (30) not null,
	Descripcion nvarchar(256) null
)
SELECT * FROM Categoria
insert into Categoria values('PINTURERIA','LAS MEJORES PINTURAS PARA TU CASA')

-- Creando Tablas: Marcas
create table Marcas(
	IdMarca int identity (1,1) primary key not null,
	Codigo as ('MR' + RIGHT('00'+CONVERT(VARCHAR, IdMarca),(2))),
	Nombre nvarchar (30) not null,
	Descripcion nvarchar (256) null
)

-- Creando Tablas: Productos
create table Productos(
	IdProducto int identity (1,1) primary key not null,
	Codigo as ('PR'+RIGHT('00'+CONVERT(VARCHAR,IdProducto),(2))),
	Producto nvarchar (50) not null,
	Precio_Compra decimal (18,2) null,
	Precio_Venta decimal (18,2) null,
	Stock int null,

	-- Fks
	IdCategoria int not null foreign key references Categoria(IdCategoria),
	IdMarca int not null foreign key references Marcas(IdMarca)
)

insert into Productos values ('TALADRO',12.50,20,100,1,1), 
							 ('SERRUCHO',8.32,12,12,1,1)

-- Creando tabla Empleados
create table Empleados(
	IdEmpleado int identity (1,1) primary key not null,
	CodigoEm as ('EM'+RIGHT('00'+CONVERT(VARCHAR,IdEmpleado),(2))),
	Puesto nvarchar(25) not null,
	PrimerNombre nvarchar(25) not null,
	PrimerApellido nvarchar (25) not null,
	FechaContrato datetime not null,
	Salario decimal (18,2) not null
)

-- Creando tabla Clientes
create table Clientes(
	IdCliente int identity (1,1) primary key not null,
	CodigoCl as ('CL'+RIGHT('00'+convert(varchar,IdCliente),(2))),
	PrimerNombre nvarchar(25) not null,
	SegundoNombre nvarchar(25) not null,
	PrimerApellido nvarchar(25) not null,
	SegundoApellido nvarchar (25) not null,
	NumeroTelf int null
)

-- Creando tabla Empleados
create table Ordenes(
	IdOrden int identity (1,1) primary key not null,
	CodigoOr as ('OR'+right('00'+convert(varchar,IdOrden),(2))),
	FechaOrden datetime not null,

	-- Fks
	IdEmpleado int not null foreign key references Empleados(IdEmpleado),
	IdCliente int not null foreign key references Clientes(IdCliente),
)

-- Creando tabla Detalles Ordenes
create table DetalleOrden(
	Precio decimal (18,2),
	Cantidad int,
	Descuento decimal (18,2),
	-- Fks

	IdOrden int not null foreign key references Ordenes(IdOrden),
	IdProducto int not null foreign key references Productos(IdProducto)
)

