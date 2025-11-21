@echo off
echo ========================================
echo   Ejecutando API Local
echo ========================================
echo.

REM Cambiar a la carpeta de la API
cd /d "%~dp0"

echo Verificando .NET...
dotnet --version
if errorlevel 1 (
    echo ERROR: .NET no esta instalado
    echo Descarga .NET 8.0 SDK de: https://dotnet.microsoft.com/download/dotnet/8.0
    pause
    exit /b 1
)

echo.
echo Restaurando paquetes...
dotnet restore

echo.
echo Ejecutando API...
echo.
echo La API estara disponible en:
echo   - https://localhost:XXXXX/api/usuarios
echo   - https://localhost:XXXXX/api/roles
echo   - https://localhost:XXXXX/swagger
echo.
echo Presiona Ctrl+C para detener la API
echo.

dotnet run

pause

