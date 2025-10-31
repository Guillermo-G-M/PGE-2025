# IncluYE Mobile

Aplicación móvil multiplataforma desarrollada con .NET MAUI que extiende el servicio web IncluYE a múltiples plataformas.

**Documentación oficial de MAUI:** https://learn.microsoft.com/es-es/dotnet/maui/

## Descripción

Esta aplicación utiliza un WebView para mostrar la aplicación web parcial2PGE (IncluYE), proporcionando una experiencia nativa en dispositivos móviles y de escritorio.

## Requisitos

- .NET 9.0 SDK
- Visual Studio 2022 con la carga de trabajo MAUI
- Android SDK (para compilación Android)
- Xcode (para compilación iOS/macOS)

## Configuración

1. Abrir el proyecto `Tarea8Parcial2.sln` en Visual Studio 2022
2. Restaurar paquetes NuGet
3. Seleccionar plataforma destino
4. Compilar y ejecutar

## Configuración del WebView

La aplicación carga la web desde la URL configurada en `MainPage.xaml`:
```xml
<WebView Source="https://miprimertrabajo.netlify.app" />
```

## Plataformas soportadas

- ✅ Android 8.0+ (API 26+)
- ✅ iOS 15.0+
- ✅ macOS Catalyst 15.0+
- ✅ Windows 10 (Build 17763+)