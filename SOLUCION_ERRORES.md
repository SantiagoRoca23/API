# 🔧 Solución de Errores Comunes en Visual Studio

## Errores Corregidos

### ✅ Error: "Nullable reference types"

**Problema:** Los modelos pueden tener warnings sobre nullable types.

**Solución aplicada:**
- ✅ `Usuario.cs` - Agregado `= string.Empty` y `?` donde corresponde
- ✅ `Rol.cs` - Agregado `= string.Empty` y `?` donde corresponde

### ✅ Error: "IConfiguration not found"

**Problema:** Los controladores necesitan IConfiguration.

**Solución:** Ya está inyectado correctamente en los constructores.

### ✅ Error: "Connection string is null"

**Problema:** La cadena de conexión puede ser null.

**Solución:** Agregar validación o usar API_SIMPLIFICADA si no tienes SQL Server.

---

## Errores Comunes y Soluciones

### Error: "The type or namespace name 'API' could not be found"

**Solución:**
1. Verifica que el namespace sea correcto
2. Rebuild Solution (Ctrl+Shift+B)
3. Limpia y reconstruye: Build → Clean Solution, luego Build → Rebuild Solution

### Error: "Program does not contain a static 'Main' method"

**Solución:**
- Este error es normal en .NET 6+, el Main está implícito
- Si persiste, verifica que `API.csproj` tenga:
  ```xml
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
  </PropertyGroup>
  ```

### Error: "Package restore failed"

**Solución:**
1. Click derecho en el proyecto → "Restore NuGet Packages"
2. O ejecuta: `dotnet restore` en la terminal

### Error: "Cannot find API.dll" (en Railway)

**Solución:**
1. Verifica que el Root Directory sea `API`
2. Verifica que el build command sea: `dotnet publish -c Release -o ./publish`
3. Verifica que el start command sea: `dotnet ./publish/API.dll`

### Error: "Connection string is null" (en Railway)

**Solución:**
1. Agrega variable de entorno en Railway:
   - Name: `ConnectionStrings__DefaultConnection`
   - Value: Tu cadena de conexión
2. O usa `API_SIMPLIFICADA` que no necesita SQL Server

### Error: "CORS policy" en Android

**Solución:**
- Ya está configurado en `Program.cs` con `AllowAll`
- Si persiste, verifica que la URL en `ApiClient.java` sea correcta

---

## Comandos Útiles

### Limpiar y Reconstruir
```bash
dotnet clean
dotnet restore
dotnet build
```

### Probar Localmente
```bash
cd API
dotnet run
```

### Publicar para Railway
```bash
cd API
dotnet publish -c Release -o ./publish
```

---

## Verificar que Todo Esté Correcto

### Checklist de Archivos:
- [ ] `API/API.csproj` existe
- [ ] `API/Program.cs` existe
- [ ] `API/Controllers/UsuariosController.cs` existe
- [ ] `API/Controllers/RolesController.cs` existe
- [ ] `API/Models/Usuario.cs` existe
- [ ] `API/Models/Rol.cs` existe
- [ ] `API/appsettings.json` existe

### Checklist de Compilación:
1. Abre Visual Studio
2. Click derecho en el proyecto `API`
3. "Restore NuGet Packages"
4. "Rebuild"
5. Si hay errores, compártelos y te ayudo

---

## 🆘 Si Aún Tienes Errores

1. **Copia el mensaje de error completo**
2. **Revisa qué archivo tiene el error**
3. **Comparte el error y te ayudo a solucionarlo**

Los errores más comunes ya están corregidos en el código. Si ves algún error específico, dímelo y lo solucionamos juntos.

