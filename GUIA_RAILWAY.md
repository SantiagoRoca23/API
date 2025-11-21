# 🚂 Guía Completa: Desplegar API en Railway

## Paso a Paso Detallado

### Paso 1: Preparar el Proyecto

1. **Asegúrate de que tu proyecto esté en GitHub:**
   - Si no está, sube tu proyecto a GitHub
   - Necesitas tener la carpeta `API` con todos los archivos

2. **Verifica que estos archivos existan:**
   - ✅ `API/API.csproj`
   - ✅ `API/Program.cs`
   - ✅ `API/Controllers/UsuariosController.cs`
   - ✅ `API/Controllers/RolesController.cs`
   - ✅ `API/Models/Usuario.cs`
   - ✅ `API/Models/Rol.cs`
   - ✅ `API/appsettings.json`

### Paso 2: Crear Cuenta en Railway

1. Ve a: **https://railway.app**
2. Click en **"Login"** o **"Start a New Project"**
3. Elige **"Login with GitHub"**
4. Autoriza Railway para acceder a tu GitHub

### Paso 3: Crear Nuevo Proyecto

1. En el dashboard de Railway, click en **"New Project"**
2. Selecciona **"Deploy from GitHub repo"**
3. Si es la primera vez, te pedirá conectar tu cuenta de GitHub
4. Autoriza Railway para acceder a tus repositorios

### Paso 4: Seleccionar Repositorio

1. Railway mostrará una lista de tus repositorios
2. Busca y selecciona el repositorio que contiene tu proyecto `APIYOFFLINE`
3. Click en el repositorio

### Paso 5: Configurar el Servicio

Railway intentará detectar automáticamente que es un proyecto .NET, pero si no lo hace:

1. Railway te preguntará qué tipo de servicio
2. Selecciona **"Web Service"** o **"Empty Service"**
3. Railway detectará automáticamente que es .NET

### Paso 6: Configurar el Root Directory

1. En la configuración del servicio, busca **"Root Directory"** o **"Source"**
2. Cambia a: `API`
   - Esto le dice a Railway que la API está en la carpeta `API`
3. Railway debería detectar automáticamente:
   - **Build Command**: `dotnet publish -c Release -o ./publish`
   - **Start Command**: `dotnet ./publish/API.dll`

### Paso 7: Configurar Variables de Entorno (Opcional)

Si vas a usar SQL Server:

1. En el servicio, ve a la pestaña **"Variables"**
2. Agrega una variable:
   - **Name**: `ConnectionStrings__DefaultConnection`
   - **Value**: Tu cadena de conexión SQL Server
   - Ejemplo: `Server=tu-servidor;Database=APIYOFFLINE;User Id=usuario;Password=pass;TrustServerCertificate=True;`

**NOTA**: Si no tienes SQL Server, puedes usar la **API_SIMPLIFICADA** que no necesita base de datos.

### Paso 8: Desplegar

1. Railway comenzará a construir automáticamente
2. Verás el progreso en la pestaña **"Deployments"**
3. Espera a que termine (puede tomar 2-5 minutos)
4. Verás un mensaje de "Deploy Successful" cuando termine

### Paso 9: Obtener la URL

1. Una vez desplegado, ve a la pestaña **"Settings"**
2. Busca **"Generate Domain"** o **"Custom Domain"**
3. Click en **"Generate Domain"**
4. Railway te dará una URL como: `https://tu-proyecto-production.up.railway.app`
5. **¡Copia esta URL!**

### Paso 10: Probar la API

1. Abre tu navegador
2. Ve a: `https://tu-proyecto-production.up.railway.app/api/usuarios`
3. Deberías ver un JSON con los usuarios (o un error si no hay base de datos configurada)

### Paso 11: Actualizar la App Android

1. Abre: `app/src/main/java/com/example/apiyoffline/api/ApiClient.java`
2. Cambia la URL:
   ```java
   private static final String BASE_URL = "https://tu-proyecto-production.up.railway.app/";
   ```
3. Reemplaza con tu URL real de Railway

---

## 🔧 Solución de Problemas

### Error: "Build Failed"

**Solución:**
1. Ve a la pestaña **"Deployments"**
2. Click en el deployment fallido
3. Revisa los logs para ver el error
4. Comúnmente es porque:
   - El Root Directory está mal configurado (debe ser `API`)
   - Faltan archivos en el repositorio

### Error: "Cannot find API.dll"

**Solución:**
1. Ve a **Settings** → **Build & Deploy**
2. Verifica que:
   - **Build Command**: `dotnet publish -c Release -o ./publish`
   - **Start Command**: `dotnet ./publish/API.dll`

### Error: "Connection String"

**Solución:**
- Si no tienes SQL Server, usa la **API_SIMPLIFICADA** en su lugar
- O configura las variables de entorno en Railway

### La API no responde

**Solución:**
1. Verifica que el puerto esté configurado
2. Railway usa automáticamente la variable `PORT`
3. Asegúrate de que `Program.cs` use: `app.Run();` sin especificar puerto

---

## 📝 Usar API Simplificada (Sin SQL Server)

Si prefieres no configurar SQL Server:

1. En Railway, cambia el **Root Directory** a: `API/API_SIMPLIFICADA`
2. Railway detectará automáticamente el proyecto
3. No necesitas configurar variables de entorno
4. ¡Funciona inmediatamente!

---

## ✅ Checklist Final

- [ ] Proyecto subido a GitHub
- [ ] Cuenta de Railway creada
- [ ] Repositorio conectado
- [ ] Root Directory configurado (`API` o `API/API_SIMPLIFICADA`)
- [ ] Deploy exitoso
- [ ] URL obtenida
- [ ] API probada en navegador
- [ ] URL actualizada en `ApiClient.java`
- [ ] App Android probada

---

## 🎯 ¿Necesitas Ayuda?

Si tienes algún error específico:
1. Copia el mensaje de error completo
2. Revisa los logs en Railway (pestaña Deployments)
3. Compárteme el error y te ayudo a solucionarlo

¡Railway es muy fácil una vez que lo configuras! 🚀

