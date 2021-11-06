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
	PrimerNombre nvarchar(25) not null,
	SegundoNombre nvarchar(25) not null,
	PrimerApellido nvarchar (25) not null,
	SegundoApellido nvarchar (25) not null,
	FechaContrato date not null,
	Salario decimal (18,2) not null,
)
alter table Empleados
		add Puesto varchar (45)
-- Agregando empleados
insert into Empleados values ('Pablo','Andres','Gutierrez','Almendarez','06-02-2003',19389.21,'Jefe de caja')
insert into Empleados values ('Ariel','Adolfo','Reyes','Silva','05-05-2003',19389.21,'Jefe de planta')
insert into Empleados values ('Wiston','Jose','Quintana','Osorio','04-12-2002',19389.21,'Jefe de inventario')
insert into Empleados values ('Fhernando','Ariel','Villanueva','Mena','12-11-2002',19389.21,'Jefe de Ventas')
select * from Empleados
-- /Agregando empleados
-- creando tabla usuario
create table Usuario (
IdUsuario int primary key identity(1,1) not null,
usuario varchar(80),
contraseña varchar(80),
estado varchar(80),
-- Fks
IdEmpleado int not null foreign key references Empleados(IdEmpleado),
IdRol int not null foreign key references Rol(IdRol)
)
--Agregando Usuarios
Execute SP_InsertarUsuario 'Pablo', 'pablo123', 'Habilitado',1,1
Execute SP_InsertarUsuario 'Ariel', 'ariel123', 'Habilitado',2,1
select * from Usuario
--/Agregando usuarios
-- <Comprobando que se muestre la informacion>
select
e.PrimerNombre,
e.PrimerApellido,
e.FechaContrato,
e.Salario,
e.Puesto,
u.usuario,
u.contraseña,
r.Rol
from Usuario u
inner join Rol r
on r.IdRol = u.IdRol
inner join Empleados e
on e.IdEmpleado = u.IdEmpleado

-- </Comprobando que se muestre la informacion>


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

-- LOGICA DE ROLES

-- Creando tabla Rol
create table Rol(
	IdRol int  primary key not null,
	Rol nvarchar(14) not null
)
insert into Rol values (1, 'Jefe'), (2, 'Administrador'), (3, 'Bodega'), (4, 'Vendedor')
select * from Rol
insert into prueba1 values ('Faviana','Jefe',1)

-- Creando tabla Modulo
create table Modulo(
	IdModulo int identity (1,1) primary key not null,
	NombreModulo nvarchar (30)
)

-- Creando tabla Operaciones
create table Operaciones(
	IdOperacion int identity (1,1) primary key not null,
	NombreOperacion nvarchar (45) not null,
	-- Fks
	IdModulo int not null foreign key references Modulo(IdModulo)
)

-- Creabdi tabka RolOperaciones
create table RolOperacion(
	IdRolOperacion int identity (1,1) primary key not null,
	-- Fk
	IdRol int not null foreign key references Rol(IdRol),
	IdOperacion int not null foreign key references Operaciones(IdOperacion)
)
