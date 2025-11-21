# API REST - Lista para Railway

API REST simplificada con datos hardcodeados, perfecta para desplegar en Railway sin necesidad de base de datos.

## ✅ Características

- ✅ Sin dependencias de SQL Server
- ✅ Datos hardcodeados (6 usuarios, 3 roles)
- ✅ CORS configurado para Android
- ✅ Lista para Railway
- ✅ Swagger en desarrollo

## 🚀 Endpoints

### GET /api/usuarios
Retorna una lista de usuarios con sus roles.

**Ejemplo de respuesta:**
```json
[
  {
    "id": 1,
    "nombre": "Juan Pérez",
    "email": "juan@ejemplo.com",
    "telefono": "1234567890",
    "rolId": 1,
    "rol": {
      "id": 1,
      "nombre": "Administrador",
      "descripcion": "Usuario con permisos completos"
    }
  }
]
```

### GET /api/roles
Retorna una lista de roles disponibles.

**Ejemplo de respuesta:**
```json
[
  {
    "id": 1,
    "nombre": "Administrador",
    "descripcion": "Usuario con permisos completos del sistema"
  }
]
```

## 🧪 Probar Localmente

1. Ejecuta el proyecto:
   ```bash
   dotnet run
   ```

2. Abre en el navegador:
   - `https://localhost:XXXXX/api/usuarios`
   - `https://localhost:XXXXX/api/roles`
   - `https://localhost:XXXXX/swagger` (solo en desarrollo)

## 🚂 Desplegar en Railway

1. Sube tu proyecto a GitHub
2. Ve a https://railway.app
3. "New Project" → "Deploy from GitHub repo"
4. Selecciona tu repositorio
5. **Root Directory**: `API`
6. Railway detecta .NET automáticamente
7. Espera el deploy (2-5 minutos)
8. Genera el dominio en Settings
9. ¡Listo! Tu API está funcionando

## 📱 Configurar App Android

1. Abre `app/src/main/java/com/example/apiyoffline/api/ApiClient.java`
2. Cambia `BASE_URL` a tu URL de Railway:
   ```java
   private static final String BASE_URL = "https://tu-proyecto.railway.app/";
   ```

## 📊 Datos Incluidos

### Usuarios (6):
- Juan Pérez (Administrador)
- María García (Usuario)
- Carlos López (Editor)
- Ana Martínez (Usuario)
- Pedro Rodríguez (Administrador)
- Laura Sánchez (Editor)

### Roles (3):
- Administrador
- Usuario
- Editor

## 🔧 Tecnologías

- .NET 8.0
- ASP.NET Core Web API
- Swagger/OpenAPI

## ✅ Sin Dependencias Externas

- ❌ No necesita SQL Server
- ❌ No necesita base de datos
- ❌ No necesita configuración adicional
- ✅ Funciona inmediatamente

¡Perfecto para pruebas y desarrollo rápido! 🚀

