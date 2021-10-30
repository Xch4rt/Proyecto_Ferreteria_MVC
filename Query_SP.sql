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

