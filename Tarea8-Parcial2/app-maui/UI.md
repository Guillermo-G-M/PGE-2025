# Configuración de Identidad de la App: IncluYE

## UI

### 1. Diseño de Iconos Personalizados

#### Proyecto MAUI
**Archivos a reemplazar**:
- `Resources/AppIcon/appicon.svg` - Icono base
- `Resources/AppIcon/appiconfg.svg` - Foreground del icono

**Especificaciones**:
- Formato: SVG
- Dimensiones: 456x456 px
- El sistema MAUI generará automáticamente todos los tamaños necesarios para cada plataforma
- Diseño sugerido: Logo de IncluYE que refleje inclusión laboral

**Acción requerida**:
1. Crear diseño del icono que represente la marca IncluYE
2. Exportar como SVG (456x456)
3. Reemplazar ambos archivos SVG en la carpeta AppIcon
4. El `appiconfg.svg` es la capa frontal (foreground) que se superpondrá sobre el color de fondo


---

### 2. Splash Screen Personalizado

#### Proyecto MAUI
**Archivo a modificar**:
- `Resources/Splash/splash.svg`

**Estado actual**:
- Logo ".NET" con texto blanco
- El color de fondo ya está configurado a `#667eea` en el .csproj

**Especificaciones**:
- Formato: SVG
- Dimensiones base: 456x456 px (configurado con BaseSize="128,128" en el .csproj)

**Acción requerida**:
1. Diseñar splash screen con branding de IncluYE
2. Puede incluir logo + nombre de la app
3. Reemplazar el SVG manteniendo las dimensiones
4. El color de fondo (#667eea) se aplicará automáticamente

---

---

### 3. Esquema de Colores - Validación

#### Colores Configurados (basados en el proyecto Angular):
- **Primary**: `#667eea` (azul/morado)
- **Primary Dark**: `#5568d3` (azul oscuro)
- **Secondary**: `#f093fb` (rosa/magenta)
- **Secondary Dark**: `#764ba2` (morado oscuro)
- **Tertiary**: `#4facfe` (azul claro/cyan)

**Acción requerida**:
1. Validar que estos colores se alineen con la identidad visual de IncluYE
2. Si es necesario, actualizar:
   - **MAUI**: `Resources/Styles/Colors.xaml` y `Platforms/Android/Resources/values/colors.xml`
   - **Angular**: `parcial2PGE/src/styles.scss` (variables CSS en `:root`)
3. Asegurar suficiente contraste para accesibilidad (WCAG AA: ratio 4.5:1)

---

---

### 4. Recursos Gráficos Adicionales

#### MAUI - Imágenes de la App
**Carpeta**: `Resources/Images/`

**Archivo actual a reemplazar/eliminar**:
- `dotnet_bot.png` - Es una imagen de ejemplo de .NET

**Acción requerida**:
1. Agregar logos, ilustraciones o imágenes propias de IncluYE
2. Eliminar o reemplazar `dotnet_bot.png` si se usa en la UI

#### Angular - Assets
**Carpeta**: `parcial2PGE/src/assets/imagen/`

**Acción requerida**:
1. Revisar y organizar todos los assets gráficos
2. Asegurar que las imágenes tengan nombres descriptivos
3. Optimizar tamaño de imágenes para web
4. Considerar usar formatos modernos (WebP) con fallbacks

---

### 5. Tipografías

#### Proyecto MAUI
**Carpeta**: `Resources/Fonts/`

**Fuentes actuales**:
- OpenSans-Regular.ttf
- OpenSans-Semibold.ttf

**Acción requerida**:
1. Evaluar si Open Sans se alinea con la identidad de marca
2. Si se requiere cambiar:
   - Agregar archivos de fuente (.ttf/.otf) a la carpeta Fonts
   - Las fuentes se incluyen automáticamente con `<MauiFont Include="Resources\Fonts\*" />`
   - Actualizar `Resources/Styles/Styles.xaml` si hay estilos específicos de fuente

#### Proyecto Angular
**Fuente actual**: Roboto (via Google Fonts)

Configurado en `index.html`:
```html
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500&display=swap">
```

**Acción requerida**:
1. Si se requiere cambiar la fuente, actualizar el link en `index.html`
2. Actualizar `styles.scss` en la regla `body { font-family: ... }`
3. Considerar agregar fuentes como self-hosted para mejor rendimiento

---

