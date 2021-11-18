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
	IdMarca int not null foreign key references Marcas(IdMarca),
	IdProveedor int not null foreign key references Proveedor(IdProveedor)
)

insert into Productos values ('TALADRO',12.50,20,100,1,1), 
							 ('SERRUCHO',8.32,12,12,1,1)

-- Creando tabla Proveedor
create table Proveedor(
	IdProveedor int identity (1,1) primary key not null,
	CodigoProveedor as ('PRO'+RIGHT('00'+CONVERT(VARCHAR,IdProveedor),(2))),
	NombreCompany nvarchar (50) not null,
	NombreContacto nvarchar (80) not null,
	Direccion nvarchar (256),
	Telf int
)

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
exec Validar_Acceso 'Ariel','ariel123'
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
insert into Clientes values ('Paolo','Andrua','Gutuarre','Almendra',12345678)
select * from Clientes
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

-- insertando datos
insert into Modulo values ('Empleados'),('Proveedores'),('Marcas'),('Categorias'),('Usuario'),('Roles'),('Productos'),('Ordenes de compra'),('Ordenes de Venta'),('Clientes')
select * from Modulo
								
								
insert into Operaciones values  -- Empleados
							   ('create',10),
							   ('update',10),
							   ('delete',10),
							   ('read',10),
							   -- Usuarios	
						       ('create',1),
							   ('update',1),
							   ('delete',1),
							   ('read',1),
							   -- Roles
							   ('create',2),
							   ('update',2),
							   ('delete',2),
							   ('read',2),
							   -- Productos
							   ('create',3),
							   ('update',3),
							   ('delete',3),
							   ('read',3),
							   -- Clientes
						       ('create',6),
							   ('update',6),
							   ('delete',6),
							   ('read',6),
							   -- Categoras
							   ('create',8),
							   ('update',8),
							   ('delete',8),
							   ('read',8),
							   -- Marcas
							   ('create',7),
							   ('update',7),
							   ('delete',7),
							   ('read',7),
							   -- Proveedores
							   ('create',9),
							   ('update',9),
							   ('delete',9),
							   ('read',9),
							   -- Ordenes de compra
							   ('generate',4),
							   -- Ordenes de venta
							   ('generate',5)
select * from Operaciones
-- /insertando datos

-- insertando los permisos en rol operacion
select * from Rol
/*Para rol Jefe*/
insert into RolOperacion values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(1,17),(1,18),(1,19),(1,20),(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29),(1,30),(1,31),(1,32),(1,33),(1,34)
/*Para rol Administrador*/
insert into RolOperacion values (2,31),(2,32),(2,33),(2,34),(2,9),(2,10),(2,11),(2,12),(2,13),(2,14),(2,15),(2,16),(2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(2,25),(2,26),(2,27),(2,28)
/*Para rol Bodega*/
insert into RolOperacion values (3,29),(3,9),(3,10),(3,11),(3,12),(3,21),(3,22),(3,23),(3,34),(3,17),(3,18),(3,19),(3,20)
/*Para rol Vendedor*/
insert into RolOperacion values (4,30)
select * from RolOperacion

--<comprombando>
select 
u.IdUsuario,
u.usuario,
r.Rol,
o.NombreOperacion,
m.NombreModulo
from Usuario u
inner join Rol r
on r.IdRol = u.IdRol
inner join RolOperacion ro
on ro.IdRol = r.IdRol
inner join Operaciones o
on o.IdOperacion = ro.IdOperacion
inner join Modulo m
on m.IdModulo = o.IdModulo
order by IdUsuario




--</comprobando>






