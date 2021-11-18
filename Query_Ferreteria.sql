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
select * from Rol


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
select * from Modulo
								
								
select * from Operaciones
-- /insertando datos

-- insertando los permisos en rol operacion
select * from Rol

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






