-- PROCEDIMIENTOS PARA CATEGORIAS
use Mantenimiento_Productos
-- Procedimiento almacendo para buscar categorias
create proc SP_BuscarCategoria
@Buscar nvarchar(20)
as 
select * from Categoria
where Nombre like  @Buscar + '%'


-- Procedimiento almacenado para insertar categoria
create proc SP_InsertarCategoria
@Nombre nvarchar(30),
@Descripcion nvarchar(256)
as 
insert into Categoria values (@Nombre, @Descripcion)


-- Procedimiento almacenado para editar categoria

create proc SP_EditarCategoria
@IdCategoria int,
@Nombre nvarchar(30),
@Descripcion nvarchar (256)
as 
update Categoria set Nombre = @Nombre, Descripcion = @Descripcion
where IdCategoria = @IdCategoria


-- Procedimiento almacenado para eliminar categoria
create proc SP_EliminarCategoria
@IdCategoria int
as 
delete Categoria 
where IdCategoria = @IdCategoria
select @@servername



-- PROCEDIMIENTOS PARA MARCAS

-- Procedimiento almacenado para buscar en Marcas
create proc SP_BuscarMarca
@Buscar varchar (30)
as 
select * from Marcas
where Nombre like @Buscar + '%'

-- Procedimiento almacenado para Insertar en marcas
create proc SP_InsertarMarca
@Nombre varchar (30),
@Descripcion varchar (256)
as 
insert into Marcas values(@Nombre, @Descripcion)

-- Procedimiento almacenado para editar en Marcas
create proc SP_EditarMarca
@IdMarca int,
@Nombre varchar (30),
@Descripcion varchar (256)
as 
update Marcas set Nombre=@Nombre, Descripcion = @Descripcion
where IdMarca = @IdMarca

-- Procedimiento almacenado para eliminar Marcas
create/*alter*/ proc SP_EliminarMarca
@IdMarca int
as 
delete Marcas
where IdMarca = @IdMarca 


-- PROCEDIMIENTOS PARA PRODUCTOS

-- Procedimiento para Listar Productos

/*create*/create proc SP_ListarProductos
as 
select top 100
p.IdProducto as [ID PRODUCTO],
p.Codigo as [CODIGO],
p.Producto as [PRODUCTO],
p.IdCategoria as [ID CATEGORIA],
c.Nombre as CATEGORIA,
p.IdMarca as [ID MARCA],
m.Nombre as MARCA,
p.Precio_Compra as [PRECIO COMPRA],
p.Precio_Venta as [PRECIO VENTA],
p.Stock as STOCK
from Productos p
inner join Categoria c 
on p.IdCategoria = c.IdCategoria
inner join Marcas m
on p.IdMarca = m.IdMarca
order by IdProducto asc

exec SP_ListarProductos

-- Procedimiento para buscar en productos
create proc SP_BuscarProductos
@Buscar nvarchar (20)
as
select top 100
p.IdProducto as [ID PRODUCTO],
p.Codigo as [CODIGO],
p.Producto as [PRODUCTO],
p.IdCategoria as [ID CATEGORIA],
c.Nombre as CATEGORIA,
p.IdMarca as [ID MARCA],
m.Nombre as MARCA,
p.Precio_Compra as [PRECIO COMPRA],
p.Precio_Venta as [PRECIO VENTA],
p.Stock as STOCK
from Productos p
inner join Categoria c 
on p.IdCategoria = c.IdCategoria
inner join Marcas m
on p.IdMarca = m.IdMarca
where Producto like @Buscar + '%'
order by p.IdProducto asc

-- Procedimiento para crear Productos
create proc SP_CrearProducto
@Producto nvarchar (30),
@Precio_Compra decimal (18,2),
@Precio_Venta decimal (18,2),
@Stock int,
@IdCategoria int,
@IdMarca int,
@IdProveedor int
as
insert into Productos values (@Producto, @Precio_Compra, @Precio_Venta, @Stock, @IdCategoria, @IdMarca, @IdProveedor)

-- Procedimiento para actualizar un producto
create proc SP_ActualizarProducto
@IdProducto int,
@Producto nvarchar (30),
@Precio_Compra decimal (18,2),
@Precio_Venta decimal (18,2),
@Stock int,
@IdCategoria int,
@IdMarca int
as
update Productos set Producto = @Producto,
					 Precio_Compra = @Precio_Compra,
					 Precio_Venta = @Precio_Venta,
					 Stock = @Stock,
					 IdCategoria = @IdCategoria,
					 IdMarca = @IdMarca
where IdProducto = @IdProducto


-- Procedimiento para eliminar productos
create proc SP_EliminarProducto
@IdProducto int
as
delete Productos
where IdProducto = @IdProducto




-- Procedimiento para obtener la suma de los ids
create proc summaryProducts
@totalCategory int output,
@totalBrand int output,
@totalProduct int output,
@totalStock int output
as
set @totalCategory = (select count(IdCategoria) as Categories from Categoria)
set @totalBrand = (select count(IdMarca) as Brands from Marcas)
set @totalProduct = (select count(IdProducto) as Products from Productos)
set @totalStock = (select sum(stock) as [Productos Totales] from Productos)


-- Procedimientos para la tabla Empleado

-- Procedimiento para insertar empleado
create/*create*/ proc InsertarEmpleado
@PrimerNombre nvarchar(25),
@PrimerApellido nvarchar(25),
@SegundoNombre nvarchar (25),
@SegundoApellido nvarchar (25),
@FechaContrato date,
@Salario decimal (18,2),
@Puesto nvarchar (45)
as
insert into Empleados values(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@FechaContrato,@Salario,@Puesto)

-- Procedimiento para actualizar Empleado
create proc SP_ActualizarEmpleado
@IdEmpleado int,
@Puesto nvarchar(25),
@PrimerNombre nvarchar(25),
@PrimerApellido nvarchar(25),
@SegundoNombre nvarchar (25),
@SegundoApellido nvarchar (25),
@FechaContrato date,
@Salario decimal (18,2)

as
update Empleados set Puesto = @Puesto,
					 PrimerNombre = @PrimerNombre,
					 PrimerApellido = @PrimerApellido,
					 SegundoNombre = @SegundoNombre,
					 SegundoApellido = @SegundoApellido,
					 FechaContrato = @FechaContrato,
					 Salario = @Salario
					 
where IdEmpleado = @IdEmpleado

-- Procedimiento para eliminar Empleado
create proc SP_EliminarEmpleado
@IdEmpleado int
as
delete Empleados
where IdEmpleado = @IdEmpleado

-- Procedimiento para buscar Empleados
create proc SP_BuscarEmpleado
@Buscar nvarchar (20)
as
select top 100
e.IdEmpleado as [ID EMPLEADO],
e.CodigoEm as [CODIGO],
e.PrimerNombre as [PRIMER NOMBRE],
e.SegundoNombre as [SEGUNDO NOMBRE],
e.PrimerApellido as [PRIMER APELLIDO],
e.SegundoApellido as [SEGUNDO APELLIDO],
e.FechaContrato as [FECHA CONTRATO],
e.Puesto as [PUESTO],
e.Salario as [SALARIO],
u.usuario as [USUARIO],
r.IdRol as [ID ROL]
from Empleados e
left join Usuario u
on e.IdEmpleado = u.IdUsuario
left join Rol r
on r.IdRol = u.IdRol
where e.PrimerNombre like @Buscar + '%'
or e.PrimerApellido like @Buscar + '%'
or e.SegundoNombre like @Buscar + '%'
or e.SegundoApellido like @Buscar + '%'
or e.Puesto like @Buscar + '%'
or u.usuario like @Buscar + '%'
order by e.IdEmpleado asc

-- Procedimiento para mostrar los empleados
create proc SP_ListarEmpleados
as
select top 100
e.IdEmpleado as [ID EMPLEADO],
e.CodigoEm as [CODIGO],
e.PrimerNombre as [PRIMER NOMBRE],
e.SegundoNombre as [SEGUNDO NOMBRE],
e.PrimerApellido as [PRIMER APELLIDO],
e.SegundoApellido as [SEGUNDO APELLIDO],
e.FechaContrato as [FECHA CONTRATO],
e.Puesto as [PUESTO],
e.Salario as [SALARIO]
--u.usuario as [USUARIO]
from Empleados e
--inner join Usuario u
--on e.IdEmpleado = u.IdEmpleado
order by e.IdEmpleado asc

exec SP_ListarEmpleados
select * from Empleados
-- Procedimiento para mostrar a los clientes que poseen usuarios
create proc SP_ListarEmpleadosUsuarios
as
select top 100
e.idEmpleado as [ID EMPLEADO],
e.CodigoEm as [CODIGO],
e.PrimerNombre as [PRIMER NOMBRE],
e.SegundoNombre as [SEGUNDO NOMBRE],
e.PrimerApellido as [PRIMER APELLIDO],
e.SegundoApellido as [SEGUNDO APELLIDO],
e.Salario as [SALARIO],
e.FechaContrato as [FECHA CONTRATO],
e.Puesto as [PUESTO],
u.usuario as [USUARIO],
r.Rol as [ROL EMPLEADO]
from Empleados e
left join Usuario u
on e.IdEmpleado = u.IdEmpleado
left join Rol r
on r.IdRol = u.IdRol
order by e.IdEmpleado asc
exec SP_ListarEmpleadosUsuarios



-- Procedimientos para los Clientes


-- Procedimiento para insertar clientes
create proc SP_InsertarCliente
@PrimerNombre nvarchar(25),
@PrimerApellido nvarchar(25),
@SegundoNombre nvarchar (25),
@SegundoApellido nvarchar (25),
@NumTelf int
as
insert into Clientes values(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@NumTelf)

-- Procedimiento para eliminar clientes
create proc SP_EliminarCliente
@IdCliente int
as
delete Clientes
where IdCliente = @IdCliente

-- Procedimiento para actualizar clientes
create proc SP_ActualizarCliente
@IdCliente int,
@PrimerNombre nvarchar(25),
@SegundoNombre nvarchar (25),
@PrimerApellido nvarchar(25),
@SegundoApellido nvarchar (25),
@NumTelf int
as
update Clientes set	 PrimerNombre = @PrimerNombre,
					 PrimerApellido = @PrimerApellido,
					 SegundoNombre = @SegundoNombre,
					 SegundoApellido = @SegundoApellido,
					 NumeroTelf = @NumTelf
where IdCliente = @IdCliente



-- Procedimientos para listar y buscar clientes
create proc SP_ListarClientes
as
select top 100
c.IdCliente as [ID CLIENTE],
c.CodigoCl as [CODIGO],
c.PrimerNombre as [PRIMER NOMBRE],
c.SegundoNombre as [SEGUNDO NOMBRE],
c.PrimerApellido as [PRIMER APELLIDO],
c.SegundoApellido as [SEGUNDO APELLIDO],
c.NumeroTelf as [NUMERO DE TELEFONO]
from Clientes c
order by c.IdCliente asc



create proc SP_BuscarCliente
@Buscar nvarchar (20)
as
select top 100
c.IdCliente as [ID CLIENTE],
c.CodigoCl as [CODIGO],
c.PrimerNombre as [PRIMER NOMBRE],
c.SegundoNombre as [SEGUNDO NOMBRE],
c.PrimerApellido as [PRIMER APELLIDO],
c.SegundoApellido as [SEGUNDO APELLIDO],
c.NumeroTelf as [NUMERO DE TELEFONO]
from Clientes c
where PrimerNombre like @Buscar + '%'
or PrimerApellido like @Buscar + '%'
or SegundoNombre like @Buscar + '%'
or SegundoApellido like @Buscar + '%'
or NumeroTelf like @Buscar + '%'
order by c.IdCliente asc

-- Procedimientos para Usuarios
 create procedure SP_InsertarUsuario
 @usuario varchar(50), @contraseña varchar(50), @Estado varchar(50), @IdEmpleado int, @IdRol int
 as
 insert into Usuario values
 (@usuario, ENCRYPTBYPASSPHRASE( @contraseña,  @contraseña),@Estado , @IdEmpleado, @IdRol)

-- Procedimiento para Validar el acceso a la bd
create /*create*/ procedure [dbo].[Validar_Acceso]
@usuario varchar(50),
@contraseña varchar(50)
as
if exists (Select usuario from Usuario
            where  cast (DECRYPTBYPASSPHRASE(@contraseña, contraseña) as Varchar(100)) = @contraseña
			 and usuario = @Usuario and Estado = 'Habilitado' )
			 select 'Acceso Exitoso' as Resultado, (e.PrimerNombre +' '+ e.PrimerApellido) as [NOMBRE], r.Rol as [ROL]
			 from Usuario u
			 inner join Empleados e
			 on e.IdEmpleado = u.IdUsuario
			 inner join Rol r
			 on u.IdRol = r.IdRol
			 where  cast (DECRYPTBYPASSPHRASE(@contraseña, u.contraseña) as Varchar(100)) = @contraseña
			 and u.usuario = @Usuario and u.Estado = 'Habilitado'

			 else
			 Select 'Acceso Denegado' as Resultado


 -- Procedimiento para buscar en Roles
 create proc SP_BuscarRol
 @Buscar nvarchar (20)
 as
 select 
 r.IdRol,
 r.Rol
 from Rol r
 where Rol like @Buscar + '%' or IdRol like @Buscar + '%'
 order by r.IdRol asc

 exec SP_BuscarEmpleado ''
 exec SP_BuscarCategoria''


 -- PROCEDIMIENTO PARA PROVEEDORES
 
 -- Procedimiento para agregar proveedores
create proc SP_InsertarProveedor
 @NombreCompany nvarchar (50),
 @NombreContacto nvarchar (80),
 @Direccion nvarchar (256),
 @Telf int
 as
 insert into Proveedor values(@NombreCompany, @NombreContacto, @Direccion, @Telf)


 -- Procedimiento para actualizar Proveedores

create proc SP_ActualizarProveedor
@IdProveedor int,
@NombreCompany nvarchar (50),
@NombreContacto nvarchar (80),
@Direccion nvarchar (256),
@Telf int
as
update Proveedor set NombreCompany = @NombreCompany,
					 NombreContacto = @NombreContacto,
					 Direccion = @Direccion,
					 Telf = @Telf
where IdProveedor = @IdProveedor

select * from Proveedor

-- Procedimiento para eliminar Proveedor

create proc SP_EliminarProveedor
@IdProveedor int
as
delete Proveedor
where IdProveedor = @IdProveedor


-- Procedimiento para listar Proveedores
create proc SP_ListarProveedores
as
select top 100
p.IdProveedor as [ID PROVEEDOR],
p.CodigoProveedor as [CODIGO],
p.NombreCompany as [NOMBRE COMPAÑIA],
p.NombreContacto as [NOMBRE CONTACTO],
p.Direccion as [DIRECCION],
p.Telf as [TELEFONO]
from Proveedor p
order by p.IdProveedor asc


-- Procedimiento para buscar Proveedores

create proc SP_BuscarProveedor
@Buscar nvarchar (20)
as
select top 100
p.IdProveedor as [ID PROVEEDOR],
p.CodigoProveedor as [CODIGO],
p.NombreCompany as [NOMBRE COMPAÑIA],
p.NombreContacto as [NOMBRE CONTACTO],
p.Telf as [TELEFONO]
from Proveedor p
where 
IdProveedor like @Buscar + '%'
or CodigoProveedor like @Buscar + '%'
or NombreCompany like @Buscar + '%'
or NombreContacto like @Buscar + '%'
or Telf like @Buscar + '%'
order by p.IdProveedor asc

-- PROCEDIMIENTOS PARA FACTURAR

create procedure SP_LastOrderID
as
select * from DetalleOrden
select * from Ordenes



