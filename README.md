# PodcastsWeb
Taller Razor pages con .NET

Esta vez crearemos una aplicación Web con acceso a una base de datos SQL Server usando las tecnologías de .NET Razor Pages y EntityFramework. 
Usaremos de nuevo la aproximación Code First para crear un modelo de datos que luego migraremos a la base de datos SQL Server.

Seguiremos el tutorial https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-5.0, aunque en clase sólo se completará hasta añadir el modelo y hacer scaffold.
El resto se deja como opcional para los alumnos que vayan queriendo introducir mejoras en la actividad que tendrán que presentar realizada por ellos.

Lo que se ha realizado es:
1. Crear una Aplicación Web ASP.NET Core y ejecutarla, ya que la plantilla inicial viene con una web de prueba.
2. Crear un modelo de datos, en el caso del taller se crea una entidad Podcast con algunos campos de distintos tipos para tener variedad.
3. Hacer scaffolding del modelo Podcast para crear sus páginas CRUD y sus respectivos controladores. (en este paso se instalan muchas dependencias
y puede dar error, simplemente intentar de nuevo)
4. Migrar el modelo de datos a la base de datos usando las herramientas de consola de administración de paquetes del proyecto (vistas taller anterior):
* Cambiar la cadena de conexion previamente, poniendo correctamente el servidor y el nombre de bbdd que se quiera.
		Add-Migration InitialCreate
		Update-Database

5. Verificar que la base de datos se haya creado correctamente, arrancar el proyecto y probar la Web: http://localhost:<port>/podcasts

Tecnologías vistas en el taller: EntityFramework, Razor Pages
