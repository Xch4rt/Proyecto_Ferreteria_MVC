-- Insertando datos en las tablas
use Mantenimiento_Productos
-- En Categorias
insert into Categoria values('HERRAMIENTAS DE MANO','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('ESCALERAS','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('ARTICULOS DE SEGURIDAD','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('TUBERIAS','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('PLOMERIA','EXPERTOS EN PLOMERIA NACIONAL')
INSERT INTO CATEGORIA VALUES('CONSTRUCCION','LOS MEJORES MATERIALES PARA LOS CIMIENTOS DE TU HOGAR')
INSERT INTO CATEGORIA VALUES('BAÑO','DESTACAMOS EN LA CALIDAD DE NUESTRO INVENTARIO PARA BAÑOS')
INSERT INTO CATEGORIA VALUES('ILUMINACION','LAS MEJORES LAMPARAS DEL PAIS')
INSERT INTO CATEGORIA VALUES('VENTILADORES','LAS MEJORES VENTILIACIONES PARA TU OFICINA U HOGAR')
-- En Marcas
insert into Marcas values('BlACK AND DECKER','HERRAMIENTAS ELECTRICAS, INALAMBRICAS')
insert into Marcas values('MAKITA','HERRAMIENTAS, JARDINERIA, ELECTRICA')
insert into Marcas values('EVANS','JARDINERIA, CONSTRUCCION')
insert into Marcas values('TRUPER','HERRAMIENTA DE USO MANUAL Y ACCESORIOS')
insert into Marcas values('YALE','CERRADURA Y HERRAJES')
INSERT INTO MARCAS VALUES('INTAKO','DE LOS MEJORES CEMENTOS DEL PAIS')
INSERT INTO MARCAS VALUES('WESTINGHOUSE','LA MEJOR CALIDAD EN VENTILACION DEL PAIS')
-- En Productos
insert into Productos values ('TALADRO',12.50,20,100,1,1,1)
insert into Productos values ('SERRUCHO',8.32,12,12,1,1,1)
INSERT INTO PRODUCTOS VALUES ('REPELLO CONSTRUCCION',128.35,136.55,20,5,6,2)
INSERT INTO PRODUCTOS VALUES ('LAMPARAS DE RECAMARA',180.20,320.30,35,8,6,1)
INSERT INTO PRODUCTOS VALUES ('ARO DE INODORO, CERAMICA',300.50,520.50,7,6,6,1)
INSERT INTO PRODUCTOS VALUES ('ABANICO DE PEDESTAL',642,819,3,9,7,1)
INSERT INTO PRODUCTOS VALUES ('ESCALERAS METALICAS',769.22,799.99,10,2,4,3)

-- En Proveedores
insert into Proveedor values ('CADUR','CHEPITO ARIAS','PLAZA ESPAÑA, EDIFICIO MALAGA MODULO B-11',22661355)
INSERT INTO PROVEEDOR VALUES ('CEMENTOS.INC','FELIPE GURRIO','DEL HOSPITAL MILITAR, 30 VARAS AL SUR',21324459)
INSERT INTO PROVEEDOR VALUES ('MADERAS.INC','CARLOS MEJIA','MERCADO ORIENTAL',33329900)
SELECT * FROM PROVEEDOR

-- En Empleados
insert into Empleados values ('Pablo','Andres','Gutierrez','Almendarez','06-02-2003',19389.21,'Jefe de caja')
insert into Empleados values ('Ariel','Adolfo','Reyes','Silva','05-05-2003',19389.21,'Jefe de planta')
insert into Empleados values ('Wiston','Jose','Quintana','Osorio','04-12-2002',19389.21,'Jefe de inventario')
insert into Empleados values ('Fhernando','Ariel','Villanueva','Mena','12-11-2002',19389.21,'Jefe de Ventas')

-- En Clientes
insert into Clientes values ('Paolo','Andrua','Gutuarre','Almendra',12345678)
insert into Clientes values ('Arielo','Adolfoso','Reyeses','Sivador',87654321)
insert into Clientes values ('Wistonso','Josefo','Quintanaso','Osorioso',01234567)
insert into Clientes values ('Fhernandhino','Arielaso','Villavieja','Menudo',98765432) 
-- En Roles
insert into Rol values (1, 'Jefe'), (2, 'Administrador'), (3, 'Bodega'), (4, 'Vendedor')


-- En Modulos
insert into Modulo values ('Empleados'),('Proveedores'),('Marcas'),('Categorias'),('Usuario'),('Roles'),('Productos'),('Ordenes de compra'),('Ordenes de Venta'),('Clientes')

-- En Operaciones

insert into Operaciones values  -- Empleados
							   ('create',1),
							   ('update',1),
							   ('delete',1),
							   ('read',1),
							   -- Usuarios	
						       ('create',5),
							   ('update',5),
							   ('delete',5),
							   ('read',5),
							   -- Roles
							   ('create',6),
							   ('update',6),
							   ('delete',6),
							   ('read',6),
							   -- Productos
							   ('create',7),
							   ('update',7),
							   ('delete',7),
							   ('read',7),
							   -- Clientes
						       ('create',10),
							   ('update',10),
							   ('delete',10),
							   ('read',10),
							   -- Categoras
							   ('create',4),
							   ('update',4),
							   ('delete',4),
							   ('read',4),
							   -- Marcas
							   ('create',3),
							   ('update',3),
							   ('delete',3),
							   ('read',3),
							   -- Proveedores
							   ('create',2),
							   ('update',2),
							   ('delete',2),
							   ('read',2),
							   -- Ordenes de compra
							   ('generate',8),
							   ('read',2),
							   -- Ordenes de venta
							   ('generate',9),
							   ('create',10),
							   ('read',10)


-- En RolOperacion
/*Para rol Jefe*/
insert into RolOperacion values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(1,17),(1,18),(1,19),(1,20),(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29),(1,30),(1,31),(1,32),(1,33),(1,34),(1,35),(1,36),(1,37)
/*Para rol Administrador*/
insert into RolOperacion values (2,1),(2,2),(2,3),(2,4),(2,32),(2,16),(2,5),(2,6),(2,7),(2,8)
/*Para rol Bodega*/
insert into RolOperacion values (3,13),(3,14),(3,15),(3,16),(3,3),(3,25),(3,26),(3,27),(3,28),(3,21),(3,22),(3,23),(3,24),(3,33),(3,34),(3,29)
/*Para rol Vendedor*/
insert into RolOperacion values (4,35),(4,36),(4,37)


exec SP_InsertarUsuario 'Pablo','pablo123','Habilitado',1,1
exec SP_InsertarUsuario 'Ariel','ariel123','Habilitado',2,1
exec SP_InsertarUsuario 'Wiston','wiston123','Habilitado',3,2
exec SP_InsertarUsuario 'Fhernando','fhernando123','Habilitado',4,3



select 
e.CodigoEm,
concat(e.primernombre,' ',e.segundonombre,' ',e.primerapellido,' ',e.segundoapellido) [NOMBRE],
e.fechacontrato,
e.salario,
e.puesto,
u.usuario,
u.estado,
r.rol,
o.nombreoperacion [PERMISOS],
m.nombremodulo [EN DONDE TIENE PERMISOS]
from Empleados e
join Usuario u
on u.IdEmpleado = e.IdEmpleado
join Rol r
on r.IdRol = u.IdRol
join RolOperacion ro
on ro.IdRol = r.IdRol
join Operaciones o
on o.idoperacion = ro.idoperacion
join modulo m
on m.idmodulo = o.idmodulo
where e.codigoem = 'em03'


INSERT INTO Ordenes VALUES ('2021-05-12',4,4)
INSERT INTO Ordenes VALUES ('2021-05-22',4,3)
INSERT INTO Ordenes VALUES ('2021-06-02',4,2)
INSERT INTO Ordenes VALUES ('2021-06-10',4,1)
INSERT INTO Ordenes VALUES ('2021-06-29',4,4)
INSERT INTO Ordenes VALUES ('2021-08-11',4,3)
INSERT INTO Ordenes VALUES ('2021-09-20',4,2)
INSERT INTO Ordenes VALUES ('2021-10-30',4,1)

insert into DetalleOrden values (20.00, 2, 0.10, 1, 4)
insert into DetalleOrden values (12.00, 1, 0.10, 1, 5)
insert into DetalleOrden values (136.55, 5, 0.10, 1, 6)
insert into DetalleOrden values (799.99, 1, 0.05, 2, 10)
insert into DetalleOrden values (819.00, 2, 0.25, 3, 9)
insert into DetalleOrden values (320.30, 4, 0.25, 3, 7)
insert into DetalleOrden values (136.55, 10, 0.15, 4, 6)
insert into DetalleOrden values (20.00, 2, 0.10, 5, 4)
insert into DetalleOrden values (136.55, 6, 0.10,5, 6)
insert into DetalleOrden values (520.50, 2, 0.15, 6,8)
insert into DetalleOrden values (799.99, 1, 0.25, 7, 10)
insert into DetalleOrden values (20.00, 3, 0.15, 8, 4)
insert into DetalleOrden values (12.00, 3, 0.15,8, 4)
insert into DetalleOrden values (799.99, 1, 0.15, 8, 10)

select * from DetalleOrden

