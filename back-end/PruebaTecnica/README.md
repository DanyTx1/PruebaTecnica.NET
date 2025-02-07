# PruebaTecnica

Backend - API REST para Gestion de Alumnos

Descripcion

Este proyecto es una API REST desarrollada en .NET Core que permite gestionar alumnos, 
incluyendo insercion y consulta de registros por grado.

Requisitos Previos

	.NET 6 o superior

	MySQL (o MariaDB)

	Visual Studio o VS Code

	Postman (Opcional para pruebas)

1. Configurar la Base de Datos

 Modificar appsettings.json para agregar la cadena de conexion a MySQL:

	"ConnectionStrings": {
	  "DefaultConnection": "server=localhost;database=TuBaseDeDatos;user=TuUsuario;password=tucontraseña"
	}

2. Aplicar Migraciones y Crear BD
	Desde la consola de Visual Studio o VS Code, ejecutar el siguiente comando para aplicar las migraciones y crear la base de datos:	
	
	add-migration NombreDeTuMigracion
	update database

Ejecucion del Proyecto

	Desde Visual Studio o VS Code, ejecutar el proyecto presionando F5.

	La API estara disponible en la URL: https://localhost:7056/swagger/index.html

Endpoints Disponibles

	Metodo	 Endpoint					Descripcion
	GET		 /Api/Alumno?grado={id}		Obtiene alumnos por grado
	POST	 /Api/Alumno				Agrega un nuevo alumno


Tecnologias Usadas

	.NET Core 6

	Entity Framework Core

	MySQL

	Swagger

	CORS