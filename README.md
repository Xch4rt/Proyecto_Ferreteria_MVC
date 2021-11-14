# Proyecto_Ferreteria_MVC

Realizado por:
<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Pablo Gutiérrez](https://github.com/Xch4rt)
<br/>
&nbsp;&nbsp;&nbsp;&nbsp;[Ariel Reyes](https://github.com/Ariel-r03)

Proyecto desarollado con la arquitectura de N capas
<br>
&nbsp;&nbsp;&nbsp;&nbsp;Capa Presentacion<br>
&nbsp;&nbsp;&nbsp;&nbsp;Capa Negocios<br>
&nbsp;&nbsp;&nbsp;&nbsp;Capa Datos<br>
&nbsp;&nbsp;&nbsp;&nbsp;Capa Entidades<br>
Se utiliza el patron de diseño MVC

Al estar usando la arquitectura de N capas, tenemos que crear bibliotecas de clases y relacionarlas con la siguiente logica

![diagrama del proyecto](https://user-images.githubusercontent.com/35347784/141604375-f767d789-5df1-4175-9fe3-30756a96e1ed.png)

<br>
Para agregar las referencias guiarse con las ss de abajo
<br>

![imagen](https://user-images.githubusercontent.com/35347784/138581567-4d29a431-d6bd-42e4-a031-ff712c074c17.png)

![imagen](https://user-images.githubusercontent.com/35347784/138581757-6b2c5bd3-8728-410e-b687-f2e4b9f051c1.png)

<br>
_Tener en cuenta:_

```
<connectionStrings>
	<add name="conectar" connectionString="Server=SERVERNAME;Integrated Security=yes;Database=Mantenimiento_Productos" />
</connectionStrings>
```
*Al momento de ejecutar, ir a Presentacion/App.config para cambiar la conexion al servidor, colocar el nombre del servidor en donde dice SERVERNAME*
<br>
#### Como saber cual es el nombre de mi servidor?
<br>
Si estamos ubicados en un script de SQL Server, escribir el siguiente script;
`select @@SERVERNAME`
Esto nos dará el nombre del servidor local
