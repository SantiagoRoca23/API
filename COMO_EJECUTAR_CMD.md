# 🖥️ Cómo Ejecutar la API desde CMD (Windows)

## 📋 Pasos Exactos

### Paso 1: Abrir CMD
1. Presiona `Windows + R`
2. Escribe: `cmd`
3. Presiona Enter

### Paso 2: Ir a la Carpeta del Proyecto
Copia y pega estos comandos uno por uno:

```cmd
cd C:\Users\Santiago\AndroidStudioProjects\APIYOFFLINE
```

Luego:

```cmd
cd API
```

### Paso 3: Verificar que Estás en la Carpeta Correcta
Deberías ver algo como:
```
C:\Users\Santiago\AndroidStudioProjects\APIYOFFLINE\API>
```

### Paso 4: Verificar que Tienes .NET Instalado
Ejecuta:
```cmd
dotnet --version
```

**Si ves un error:**
- Necesitas instalar .NET 8.0 SDK
- Descarga de: https://dotnet.microsoft.com/download/dotnet/8.0
- Instala y reinicia CMD

**Si ves una versión (ej: 8.0.xxx):**
- ✅ Tienes .NET instalado, continúa

### Paso 5: Restaurar Paquetes (Primera Vez)
```cmd
dotnet restore
```

Espera a que termine (puede tomar 1-2 minutos).

### Paso 6: Ejecutar la API
```cmd
dotnet run
```

### Paso 7: Ver la URL
Deberías ver algo como:
```
Now listening on: https://localhost:49789
Now listening on: http://localhost:49790
```

### Paso 8: Probar en el Navegador
Abre tu navegador y ve a:
```
https://localhost:49789/api/usuarios
```

O:
```
http://localhost:49790/api/usuarios
```

---

## 🔧 Solución de Problemas

### Error: "No se reconoce 'dotnet' como comando"
**Solución:**
1. Instala .NET 8.0 SDK: https://dotnet.microsoft.com/download/dotnet/8.0
2. Reinicia CMD después de instalar
3. Verifica con: `dotnet --version`

### Error: "No se puede encontrar el proyecto"
**Solución:**
1. Verifica que estés en la carpeta correcta:
   ```cmd
   dir
   ```
2. Deberías ver `API.csproj` en la lista
3. Si no lo ves, usa:
   ```cmd
   cd C:\Users\Santiago\AndroidStudioProjects\APIYOFFLINE\API
   ```

### Error: "No se puede encontrar la ruta especificada"
**Solución:**
1. Verifica que la ruta sea correcta
2. Usa comillas si hay espacios:
   ```cmd
   cd "C:\Users\Santiago\AndroidStudioProjects\APIYOFFLINE\API"
   ```

### Error al Ejecutar: "Build failed"
**Solución:**
1. Limpia el proyecto:
   ```cmd
   dotnet clean
   ```
2. Restaura paquetes:
   ```cmd
   dotnet restore
   ```
3. Reconstruye:
   ```cmd
   dotnet build
   ```
4. Ejecuta de nuevo:
   ```cmd
   dotnet run
   ```

---

## 📝 Comandos Rápidos (Copia y Pega)

```cmd
cd C:\Users\Santiago\AndroidStudioProjects\APIYOFFLINE\API
dotnet restore
dotnet run
```

---

## ✅ Verificación Final

Si todo funciona correctamente, deberías ver:
1. ✅ CMD muestra "Now listening on: https://localhost:XXXXX"
2. ✅ Puedes abrir la URL en el navegador
3. ✅ Ves JSON con los usuarios

---

## 🎯 Alternativa: Usar Visual Studio

Si CMD te da problemas, puedes usar Visual Studio:
1. Abre Visual Studio
2. Abre el proyecto `API/API.csproj`
3. Presiona **F5** o click en "Run"
4. La API se ejecutará automáticamente

---

## 💡 Tip: Usar PowerShell

Si prefieres PowerShell (más moderno):
1. Presiona `Windows + X`
2. Selecciona "Windows PowerShell" o "Terminal"
3. Sigue los mismos comandos

¡Debería funcionar perfectamente! 🚀

