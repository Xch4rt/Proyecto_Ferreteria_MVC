use Mantenimiento_Productos
go
create login Ariel with password='ariel123'


sp_adduser Ariel, Ariel
GRANT EXECUTE ON Schema:: DBO to Ariel

Create table Usuario (IdUsuario int primary key identity(1,1),
usuario varchar(80),
contrase�a varchar(80),
rol varchar(80),
estado varchar(80))


Alter table Usuario
 add IdColaborador int




 Create procedure [dbo].[Insertar_Usuario]
 @usuario varchar(50), @contrase�a varchar(50), @rol varchar(50)
 as
 insert into Usuario(usuario, contrase�a, rol, Estado) values
 (@usuario, ENCRYPTBYPASSPHRASE( @contrase�a,  @contrase�a), @rol, 'Habilitado')

 
 Create table Colaborador
(IdColaborador int primary key identity(1,1),
 primernombre varchar(60),
 primerapellido varchar(60))

 insert into Colaborador values ('Ariel', 'Reyes')
  update Usuario set IdColaborador = 1
  Select * from Colaborador
 --insert into Usuario(usuario, contrase�a, rol, estado)
 --values ('uni', 'sistemas2021', 'Administrador')


 Execute dbo.Insertar_Usuario 'Ariel', 'ariel123', 'Administrador'
 Select * from Usuario
 Select * from Colaborador
 update Usuario set estado = 'Habilitado' where IdUsuario = 1






alter /*create*/ procedure [dbo].[Validar_Acceso]
@usuario varchar(50),
@contrase�a varchar(50)
as
if exists (Select usuario from Usuario
            where  cast (DECRYPTBYPASSPHRASE(@contrase�a, contrase�a) as Varchar(100)) = @contrase�a
			 and usuario = @Usuario and Estado = 'Habilitado' )
			 select 'Acceso Exitoso' as Resultado, e.PrimerNombre +' '+ e.PrimerApellido, rol
			 from Usuario u
			 inner join Empleados e
			 on e.IdEmpleado = u.IdColaborador
			  where  cast (DECRYPTBYPASSPHRASE(@contrase�a, u.contrase�a) as Varchar(100)) = @contrase�a
			 and u.usuario = @Usuario and u.Estado = 'Habilitado'

			 else
			 Select 'Acceso Denegado' as Resultado

			 Execute dbo.Validar_Acceso 'Ariel', 'ariel123'
