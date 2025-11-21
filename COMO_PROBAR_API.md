# 🧪 Cómo Probar la API Localmente

## ❌ Problema: Error 404

Estás viendo un error 404 porque estás accediendo a la raíz (`/`), pero la API no tiene una ruta en la raíz.

## ✅ Solución: Usar las Rutas Correctas

### Paso 1: Verificar que la API esté Ejecutándose

1. En Visual Studio, presiona **F5** o click en **"Run"**
2. Deberías ver en la consola algo como:
   ```
   Now listening on: https://localhost:49789
   Now listening on: http://localhost:49790
   ```

### Paso 2: Probar los Endpoints Correctos

La API tiene estas rutas:

#### ✅ Endpoint de Usuarios
```
https://localhost:49789/api/usuarios
```
o
```
http://localhost:49790/api/usuarios
```

#### ✅ Endpoint de Roles
```
https://localhost:49789/api/roles
```
o
```
http://localhost:49790/api/roles
```

#### ✅ Swagger UI (Solo en Development)
```
https://localhost:49789/swagger
```

### Paso 3: Probar en el Navegador

1. Abre tu navegador
2. Ve a: `https://localhost:49789/api/usuarios`
3. Deberías ver un JSON con los usuarios

---

## 🔧 Si Aún No Funciona

### Problema 1: La API no inicia

**Síntomas:**
- No ves mensajes en la consola
- Error al ejecutar

**Solución:**
1. Verifica que no haya errores de compilación
2. Click derecho en el proyecto → "Clean"
3. Click derecho → "Rebuild"
4. Intenta ejecutar de nuevo

### Problema 2: Error de Conexión a SQL Server

**Síntomas:**
- La API inicia pero da error 500
- Error en la consola sobre conexión

**Solución:**
1. Verifica `appsettings.json`
2. O usa la **API_SIMPLIFICADA** que no necesita SQL Server

### Problema 3: Certificado SSL

**Síntomas:**
- Error de certificado en el navegador

**Solución:**
1. Click en "Avanzado" en el navegador
2. Click en "Continuar a localhost (no seguro)"
3. O usa HTTP: `http://localhost:49790/api/usuarios`

---

## 📋 Checklist de Prueba

- [ ] La API está ejecutándose (F5 en Visual Studio)
- [ ] Veo mensajes en la consola con los puertos
- [ ] Accedo a `/api/usuarios` (no solo `/`)
- [ ] Veo JSON en el navegador
- [ ] No hay errores en la consola

---

## 🎯 URLs Correctas para Probar

### ✅ Correctas:
- `https://localhost:49789/api/usuarios` ✅
- `https://localhost:49789/api/roles` ✅
- `https://localhost:49789/swagger` ✅ (solo en desarrollo)

### ❌ Incorrectas:
- `https://localhost:49789/` ❌ (404 - no hay ruta en la raíz)
- `https://localhost:49789/api` ❌ (404 - falta el controlador)

---

## 💡 Tip: Usar Swagger

Si estás en modo Development, puedes usar Swagger:
1. Ve a: `https://localhost:49789/swagger`
2. Verás una interfaz gráfica con todos los endpoints
3. Puedes probarlos directamente desde ahí

---

## 🚀 Próximo Paso: Railway

Una vez que la API funcione localmente:
1. Sigue `PASOS_RAILWAY.md`
2. Despliega en Railway
3. Actualiza la URL en `ApiClient.java`

¡La API debería funcionar perfectamente! 🎉

