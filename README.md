# TaskManager Web Application

TaskManager es una aplicación web desarrollada con **.NET 6** y **ASP.NET Core**, utilizando **Blazor** para el frontend y **JWT** para la autenticación segura. La aplicación permite la gestión eficiente de tareas mediante operaciones CRUD, asignación de responsabilidades y administración de usuarios. 

## Características Principales
- **Autenticación segura** mediante **JSON Web Tokens (JWT)**.
- **Gestión de tareas**: creación, actualización, eliminación y asignación de tareas.
- **Interfaz dinámica** desarrollada con **Blazor/Razor**.
- **Backend robusto** en **ASP.NET Core**.
- **Base de datos escalable** utilizando **SQL Server** o **PostgreSQL**.

## Tecnologías Utilizadas
- **Backend**: ASP.NET Core 6
- **Frontend**: Blazor / Razor
- **Base de Datos**: SQL Server o PostgreSQL
- **Autenticación**: JWT (JSON Web Tokens)
- **ORM**: Entity Framework Core
- **HttpClient** para solicitudes HTTP
- **Data Annotations** para validación de formularios

## Requisitos Previos
- **.NET SDK 6.0** o superior
- **SQL Server** o **PostgreSQL** configurado
- **Visual Studio** o **VS Code**

## Instalación y Configuración
1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/taskmanager.git
   cd taskmanager
   ```
2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```
3. Configura la cadena de conexión en `appsettings.json`.
4. Ejecuta las migraciones de la base de datos:
   ```bash
   dotnet ef database update
   ```
5. Compila y ejecuta la aplicación:
   ```bash
   dotnet run
   ```
6. Accede a la aplicación en tu navegador:
   ```
   https://localhost:5001
   ```

## Uso
- **Inicio de sesión**: Utiliza las credenciales configuradas previamente.
- **Administración de tareas**: Crea, actualiza y elimina tareas desde la interfaz.
- **Asignación de usuarios**: Asigna tareas a usuarios registrados.

## Contribución
Las contribuciones son bienvenidas. Para contribuir:
1. Realiza un fork del repositorio.
2. Crea una nueva rama:
   ```bash
   git checkout -b feature/nueva-funcionalidad
   ```
3. Realiza tus cambios y crea un commit:
   ```bash
   git commit -m "Agrega nueva funcionalidad X"
   ```
4. Sube los cambios:
   ```bash
   git push origin feature/nueva-funcionalidad
   ```
5. Crea un Pull Request en GitHub.

## Licencia
Este proyecto está licenciado bajo la [Licencia MIT](LICENSE).
