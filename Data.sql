-- Insertando datos en las tablas

-- En Categorias
insert into Categoria values('HERRAMIENTAS DE MANO','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('ESCALERAS','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('ARTICULOS DE SEGURIDAD','LAS MEJORES PINTURAS PARA TU CASA')
insert into Categoria values('TUBERIAS','LAS MEJORES PINTURAS PARA TU CASA')

-- En Marcas
insert into Marcas values('BlACK AND DECKER','HERRAMIENTAS ELECTRICAS, INALAMBRICAS')
insert into Marcas values('MAKITA','HERRAMIENTAS, JARDINERIA, ELECTRICA')
insert into Marcas values('EVANS','JARDINERIA, CONSTRUCCION')
insert into Marcas values('TRUPER','HERRAMIENTA DE USO MANUAL Y ACCESORIOS')
insert into Marcas values('YALE','CERRADURA Y HERRAJES')


-- En Productos
insert into Productos values ('TALADRO',12.50,20,100,1,1,1)
insert into Productos values ('SERRUCHO',8.32,12,12,1,1,1)

-- En Proveedores
insert into Proveedor values ('CADUR','CHEPITO ARIAS','PLAZA ESPAÑA, EDIFICIO MALAGA MODULO B-11',22661355)
	

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


-- En RolOperacion
/*Para rol Jefe*/
insert into RolOperacion values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(1,17),(1,18),(1,19),(1,20),(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29),(1,30),(1,31),(1,32),(1,33),(1,34)
/*Para rol Administrador*/
insert into RolOperacion values (2,31),(2,32),(2,33),(2,34),(2,9),(2,10),(2,11),(2,12),(2,13),(2,14),(2,15),(2,16),(2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(2,25),(2,26),(2,27),(2,28)
/*Para rol Bodega*/
insert into RolOperacion values (3,29),(3,9),(3,10),(3,11),(3,12),(3,21),(3,22),(3,23),(3,34),(3,17),(3,18),(3,19),(3,20)
/*Para rol Vendedor*/
insert into RolOperacion values (4,30)


