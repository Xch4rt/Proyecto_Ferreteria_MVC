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
create proc SP_EliminarMarca
@IdMarca int
as 
delete Marca
where IdMarca = @IdMarca 
