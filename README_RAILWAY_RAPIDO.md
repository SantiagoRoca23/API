# ⚡ Guía Rápida Railway (5 minutos)

## Pasos Súper Rápidos:

### 1. Sube tu proyecto a GitHub
- Si no está, súbelo ahora

### 2. Ve a Railway
- https://railway.app
- Login con GitHub

### 3. Nuevo Proyecto
- Click "New Project"
- "Deploy from GitHub repo"
- Selecciona tu repositorio

### 4. Configuración
- **Root Directory**: `API` (o `API/API_SIMPLIFICADA` si no tienes SQL Server)
- Railway detecta .NET automáticamente

### 5. Espera el Deploy
- Railway construye automáticamente
- Espera 2-5 minutos

### 6. Obtén la URL
- Ve a "Settings"
- Click "Generate Domain"
- Copia la URL

### 7. Actualiza Android
- Abre `ApiClient.java`
- Cambia `BASE_URL` a tu URL de Railway

## ✅ ¡Listo!

Prueba en navegador: `tu-url-railway.app/api/usuarios`

---

## 🆘 Si hay errores:

**Error de build:**
- Verifica que Root Directory sea `API`
- Revisa los logs en Railway

**No encuentra API.dll:**
- Verifica que el build haya terminado
- Revisa que el Root Directory sea correcto

**API no responde:**
- Espera 1-2 minutos después del deploy
- Verifica que el dominio esté generado

---

## 💡 Tip: Usa API_SIMPLIFICADA

Si no tienes SQL Server configurado:
- Root Directory: `API/API_SIMPLIFICADA`
- No necesitas variables de entorno
- Funciona inmediatamente

