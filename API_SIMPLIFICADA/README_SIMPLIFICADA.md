# API Simplificada - Sin SQL Server

Esta versión de la API **NO necesita SQL Server** ni configuración de base de datos. Los datos están hardcodeados y funcionan perfectamente para probar la aplicación Android.

## ✅ Ventajas
- ✅ No necesitas configurar SQL Server
- ✅ No necesitas Somee ni servicios complejos
- ✅ Funciona igual para la app Android
- ✅ Más fácil de desplegar

## 🚀 Cómo usar

### Opción 1: Ejecutar localmente (Más fácil)

1. Abre una terminal en la carpeta `API_SIMPLIFICADA`
2. Ejecuta:
   ```bash
   dotnet run
   ```
3. La API estará en: `https://localhost:5001` o `http://localhost:5000`
4. Prueba en el navegador: `http://localhost:5000/api/usuarios`

### Opción 2: Exponer con ngrok (Para usar desde Android)

1. Ejecuta la API localmente (paso anterior)
2. Descarga ngrok: https://ngrok.com/download
3. Ejecuta:
   ```bash
   ngrok http 5000
   ```
4. ngrok te dará una URL pública como: `https://abc123.ngrok.io`
5. Usa esa URL en `ApiClient.java` de tu app Android

### Opción 3: Desplegar en Railway (Gratis, fácil)

1. Ve a: https://railway.app
2. Crea cuenta (puedes usar GitHub)
3. Click en "New Project" → "Deploy from GitHub repo"
4. Conecta tu repositorio
5. Selecciona la carpeta `API_SIMPLIFICADA`
6. Railway detecta .NET automáticamente
7. ¡Listo! Te da una URL pública automáticamente

### Opción 4: Desplegar en Render (Gratis, fácil)

1. Ve a: https://render.com
2. Crea cuenta
3. Click en "New" → "Web Service"
4. Conecta tu repositorio de GitHub
5. Configura:
   - **Name**: api-simplificada
   - **Root Directory**: `API/API_SIMPLIFICADA`
   - **Build Command**: `dotnet publish -c Release -o ./publish`
   - **Start Command**: `dotnet API_SIMPLIFICADA.dll`
6. Click "Create Web Service"
7. ¡Listo! Te da una URL pública

## 📱 Configurar la App Android

1. Abre `app/src/main/java/com/example/apiyoffline/api/ApiClient.java`
2. Cambia la URL:
   ```java
   // Si usas ngrok:
   private static final String BASE_URL = "https://abc123.ngrok.io/";
   
   // Si usas Railway:
   private static final String BASE_URL = "https://tu-proyecto.railway.app/";
   
   // Si usas Render:
   private static final String BASE_URL = "https://api-simplificada.onrender.com/";
   ```

## ✅ Endpoints disponibles

- `GET /api/usuarios` - Retorna 5 usuarios de ejemplo
- `GET /api/roles` - Retorna 3 roles de ejemplo

## 🎯 Para pruebas de la app Android

Esta API funciona **exactamente igual** que la versión con SQL Server para la aplicación Android. La única diferencia es que los datos están hardcodeados en lugar de venir de una base de datos.

¡Perfecto para cumplir con todos los criterios de evaluación!

