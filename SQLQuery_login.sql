use Mantenimiento_Productos
go
create login Ariel with password='ariel123'


sp_adduser Ariel, Ariel
GRANT EXECUTE ON Schema:: DBO to Ariel

Create table Usuario (IdUsuario int primary key identity(1,1),
usuario varchar(80),
contraseña varchar(80),
rol varchar(80),
estado varchar(80))


Alter table Usuario
 add IdColaborador int




 Create procedure [dbo].[Insertar_Usuario]
 @usuario varchar(50), @contraseña varchar(50), @rol varchar(50)
 as
 insert into Usuario(usuario, contraseña, rol, Estado) values
 (@usuario, ENCRYPTBYPASSPHRASE( @contraseña,  @contraseña), @rol, 'Habilitado')

 
 Create table Colaborador
(IdColaborador int primary key identity(1,1),
 primernombre varchar(60),
 primerapellido varchar(60))

 insert into Colaborador values ('Ariel', 'Reyes')
  update Usuario set IdColaborador = 1
  Select * from Colaborador
 --insert into Usuario(usuario, contraseña, rol, estado)
 --values ('uni', 'sistemas2021', 'Administrador')


 Execute dbo.Insertar_Usuario 'Ariel', 'ariel123', 'Administrador'
 Select * from Usuario
 update Usuario set estado = 'Habilitado' where IdUsuario = 1






create procedure [dbo].[Validar_Acceso]
@usuario varchar(50),
@contraseña varchar(50)
as
if exists (Select usuario from Usuario
            where  cast (DECRYPTBYPASSPHRASE(@contraseña, contraseña) as Varchar(100)) = @contraseña
			 and usuario = @Usuario and Estado = 'Habilitado' )
			 select 'Acceso Exitoso' as Resultado, c.primernombre +' '+c.primerapellido, rol
			 from Usuario u
			 inner join Colaborador c
			 on c.IdColaborador = u.IdColaborador
			  where  cast (DECRYPTBYPASSPHRASE(@contraseña, u.contraseña) as Varchar(100)) = @contraseña
			 and u.usuario = @Usuario and u.Estado = 'Habilitado'

			 else
			 Select 'Acceso Denegado' as Resultado

			 Execute dbo.Validar_Acceso 'Ariel', 'ariel123'
