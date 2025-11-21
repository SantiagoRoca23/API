# API Web para Somee

## Instrucciones para desplegar en Somee

### 1. Preparar la Base de Datos SQL Server

1. Accede a tu panel de control de Somee
2. Ve a la sección de SQL Server
3. Crea una nueva base de datos llamada `APIYOFFLINE`
4. Ejecuta el script `script_sql_server.sql` para crear las tablas y datos de ejemplo

### 2. Configurar la Cadena de Conexión

1. Edita el archivo `appsettings.json`
2. Reemplaza `TU_SERVIDOR_SQL`, `TU_USUARIO` y `TU_PASSWORD` con tus credenciales de Somee:
   ```
   "DefaultConnection": "Server=tu-servidor.somee.com;Database=APIYOFFLINE;User Id=tu_usuario;Password=tu_password;TrustServerCertificate=True;"
   ```

### 3. Desplegar en Somee

1. Compila el proyecto en modo Release
2. Sube los archivos a Somee usando FTP o el panel de control
3. Asegúrate de que la carpeta `bin/Release/net8.0` esté en la raíz de tu sitio
4. Configura Somee para usar .NET 8.0

### 4. Actualizar la URL en la App Android

1. Abre `ApiClient.java` en tu proyecto Android
2. Reemplaza `BASE_URL` con la URL de tu API en Somee:
   ```java
   private static final String BASE_URL = "https://tuproyecto.somee.com/";
   ```

## Endpoints Disponibles

- `GET /api/usuarios` - Obtiene todos los usuarios con sus roles
- `GET /api/roles` - Obtiene todos los roles

## Notas

- La API está configurada con CORS para permitir peticiones desde cualquier origen
- Asegúrate de que tu servidor SQL Server en Somee permita conexiones remotas
- Verifica que el firewall de Somee permita las conexiones a SQL Server

