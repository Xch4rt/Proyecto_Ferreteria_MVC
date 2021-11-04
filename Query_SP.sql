-- PROCEDIMIENTOS PARA CATEGORIAS

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

/*create*/alter proc SP_ListarProductos
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
@IdMarca int
as
insert into Productos values (@Producto, @Precio_Compra, @Precio_Venta, @Stock, @IdCategoria, @IdMarca)

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
use Mantenimiento_Productos
-- Procedimiento para insertar empleado
alter/*create*/ proc InsertarEmpleado
@PrimerNombre nvarchar(25),
@PrimerApellido nvarchar(25),
@SegundoNombre nvarchar (25),
@SegundoApellido nvarchar (25),
@FechaContrato date,
@Salario decimal (18,2),
@Puesto nvarchar (45)
as
insert into Empleados values(@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@FechaContrato,@Salario,@Puesto)
exec InsertarEmpleado 'Fhernando','Ariel','Villanueva','Mena','12-11-2002',19389.21,'Jefe de Ventas'

-- Procedimiento para actualizar Empleado
create proc SP_ActualizarEmpleado
@IdEmpleado int,
@Puesto nvarchar(25),
@PrimerNombre nvarchar(25),
@PrimerApellido nvarchar(25),
@SegundoNombre nvarchar (25),
@SegundoApellido nvarchar (25),
@FechaContrato date,
@Salario decimal (18,2),
@IdUsuario int
as
update Empleados set Puesto = @Puesto,
					 PrimerNombre = @PrimerNombre,
					 PrimerApellido = @PrimerApellido,
					 SegundoNombre = @SegundoNombre,
					 SegundoApellido = @SegundoApellido,
					 FechaContrato = @FechaContrato,
					 Salario = @Salario,
					 IdUsuario = @IdUsuario
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
e.IdUsuario as [ID USUARIO],
u.usuario as [USUARIO]
from Empleados e
inner join Usuario u
on e.IdUsuario = u.IdUsuario
where PrimerNombre like @Buscar + '%'
or PrimerApellido like @Buscar + '%'
or SegundoNombre like @Buscar + '%'
or SegundoApellido like @Buscar + '%'
or Puesto like @Buscar + '%'
or usuario like @Buscar + '%'
order by e.IdEmpleado asc

-- Procedimiento para mostrar los empleados
alter proc SP_ListarEmpleados
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
u.usuario as [USUARIO]
from Empleados e
inner join Usuario u
on e.IdEmpleado = u.IdEmpleado
order by e.IdEmpleado asc

exec SP_ListarEmpleados


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
@PrimerApellido nvarchar(25),
@SegundoNombre nvarchar (25),
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