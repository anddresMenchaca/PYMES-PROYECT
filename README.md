<img src="/wwwroot/images/LoginImg/logoInicio.png" alt="Descripción de la imagen" width="300"/>

# PROYECTO PYMES
Este es el repositorio oficial del Proyecto PYMES

## Video de Presentación

<a href="https://www.youtube.com/watch?v=4ckT_--Dp94">
  <img src="/wwwroot/imgDoc/mineatura.png" alt="Descripción de la miniatura" width="300">
</a>

Haga click en la miniatura.


## Tabla de Contenidos

1. [Introducción](#introducción)
2. [Descripción del Proyecto](#descripción-del-proyecto)
3. [Roles / Integrantes](#roles-e-integrantes)
4. [Arquitectura del Software](#arquitectura-del-software)
5. [Requisitos del Sistema](#requisitos-del-sistema)
6. [Instalación y Configuración](#instalación-y-configuración)
7. [Procedimiento de Hosteado y Hosting](#procedimiento-de-hosteado-y-hosting)
8. [Personalización y Configuración](#personalización-y-configuración)
9. [Seguridad](#seguridad)
10. [Depuración y Solución de Problemas](#depuración-y-solución-de-problemas)
11. [Glosario de Términos](#glosario-de-términos)
12. [Referencias y Recursos Adicionales](#referencias-y-recursos-adicionales)
13. [Herramientas de Implementación](#herramientas-de-implementación)
14. [Bibliografía](#bibliografía)


## **INTRODUCCIÓN**

El proyecto Pymes se propone como un catalizador innovador para la gestión empresarial en Bolivia. A través de una aplicación web colaborativa, busca simplificar operaciones comerciales y otorgar a las pequeñas empresas una presencia online destacada.

- ### **Objetivos Principales**

    * **Simplificación de operaciones:** La aplicación está diseñada para simplificar operaciones comerciales complejas, proporcionando herramientas eficientes y accesibles.

  
    * **Empoderamiento de productores locales:** Se enfoca en empoderar a los productores locales, brindándoles herramientas efectivas para gestionar la producción de sus bienes.

- ### **Colaboración con la Universidad Univalle**

    * Con la supervisión de la Universidad Univalle, el proyecto garantiza un entorno seguro y confiable para los usuarios.

- ### **Propósito**

    * El propósito principal del proyecto es fortalecer la economía local al tiempo que impulsa la colaboración y el crecimiento empresarial en Bolivia.

- ### **Impacto Esperado**

    * En resumen, Pymes aspira a transformar la gestión empresarial, beneficiando tanto a empresas como a productores locales en Bolivia.

## **DESCRIPCIÓN DEL PROYECTO**

El proyecto Pymes presenta una innovadora iniciativa centrada en el desarrollo de una aplicación web colaborativa diseñada para mejorar la eficiencia en la gestión de pequeñas empresas en Bolivia. Esta plataforma integral no solo simplificará las operaciones comerciales, sino que también proporcionará a las empresas locales una presencia en línea mediante páginas de perfil, aumentando su visibilidad.

Además, la aplicación beneficiará a los productores locales al permitirles gestionar eficazmente la producción de sus productos. Supervisada por la Universidad Univalle, esta herramienta busca empoderar a los empresarios y fomentar la colaboración, contribuyendo al crecimiento económico sostenible y fortaleciendo el tejido empresarial en la región.


## **ROLES E INTEGRANTES**

1. **Team Líder, DB Architect, Developer:** Isabel Gonzales Vargas
2. **DB Architect, Developer:** Jhael Kuno Bustos
3. **GIT Master, Developer:** José Andrés Menchaca Mediana


## **ARQUITECTURA DEL SOFTWARE**

La arquitectura del software del proyecto PYMES ha sido cuidadosamente diseñada por nuestra arquitecta de software. Incluye un diseño de la base de datos implementado en SQL Server, utilizando un modelo de relaciones para garantizar la eficiencia y la coherencia en el almacenamiento y recuperación de datos.

Además, cabe destacar que la base de datos se caracteriza por la implementación del concepto de polimorfismo. Esto significa que la base de datos puede manejar y almacenar diferentes tipos de datos de manera dinámica, proporcionando flexibilidad y escalabilidad al sistema. Este enfoque polimórfico es fundamental para adaptarse a las necesidades cambiantes del proyecto PYMES y optimizar el rendimiento en diversas situaciones.

Este es el diagrama de la Base de Datos Relacional:

<img src="/wwwroot/imgDoc/img1.png" alt="Descripción de la imagen" width="700"/>

## **REQUISITOS DEL SISTEMA**

- **Requerimientos de Hardware (mínimo) - Cliente:**
  - **Procesador (CPU):**
    - Tipo: Intel Core i5 6ta Generación o AMD Ryzen 5.
    - Velocidad: 2.5 GHz o superior.

  - **Memoria RAM:**
    - Capacidad: 8 GB a 16 GB de RAM.
  
  - **Almacenamiento:**
    - Tipo: Disco duro (HDD) de 1 TB o unidad de estado sólido (SSD) de 256 GB. Algunas PCs pueden tener una combinación de ambos para aprovechar la velocidad del SSD y la capacidad del HDD.
  
  - **Sistema Operativo:**
    - Ejemplo: Windows 10, macOS, distribucion de Linux.
  
  - **Conectividad:**
    - Ejemplo: Wi-Fi, Bluetooth, Ethernet, etc.

- **Requerimientos de Software(obligatorio) - Cliente:**
  - Tener un navegador web.

- **Requerimientos de Hardware (minimo) (servidor/hosting/BD):**
  - **Procesador (CPU):**
    - Tipo: Intel Xeon, AMD Ryzen u opciones similares para servidores.
    - Velocidad: Dependerá de la carga esperada. Al menos 2.5 GHz o superior para un rendimiento óptimo.

  - **Memoria RAM:**
    - Capacidad: Recomendado de 8 GB a 16 GB para manejar las solicitudes del servidor.
  
  - **Almacenamiento:**
    - Tipo: Disco duro (HDD) de alta capacidad o unidad de estado sólido (SSD) para un mejor rendimiento.
    - Capacidad: Dependerá del tamaño de tu aplicación y la cantidad de datos a almacenar. Un mínimo de 100 GB es recomendado.
  
  - **Ancho de Banda y Tráfico Mensual:**
    - Dependiendo del tráfico esperado en tu aplicación. Considera planes con ancho de banda ilimitado o suficiente para tus necesidades previstas.
  
  - **Sistema Operativo del Servidor:**
    - Ejemplo: Linux (Ubuntu, CentOS, etc.) o Windows Server.
  
  - **Base de Datos:**
    - Soporte para la base de datos SQL Server.
  
  - **Seguridad:**
    - Certificado SSL/TLS para conexiones seguras (HTTPS).
    - Firewall y medidas de seguridad adicionales.
  
  - **Escalabilidad y Soporte Técnico:**
    - Posibilidad de escalar recursos fácilmente según las demandas del proyecto.
    - Soporte técnico confiable y accesible.
  
  - **Tiempo de Actividad (Uptime):**
    - Garantía de un alto tiempo de actividad para tu aplicación.

## **INSTALACIÓN Y CONFIGURACIÓN**

### Descarga y Preparación

1. Clonar Repositorio
``` bash
git clone https://github.com/anddresMenchaca/PYMES-PROYECT.git
```
2. Restaurar la base de datos (.bak) en SQL Server.

#### Pasos para Restaurar la Base de Datos

<img src="/wwwroot/imgDoc/img2.png" alt="Descripción de la imagen" width="500"/>

3. Seleccionar 'device' y hacer clic en los tres puntitos.

<img src="/wwwroot/imgDoc/img3.png" alt="Descripción de la imagen" width="500"/>

4. Hacer clic en 'Add' para agregar la base de datos con la extensión (.bak).

<img src="/wwwroot/imgDoc/img4.png" alt="Descripción de la imagen" width="500"/>
<img src="/wwwroot/imgDoc/img5.png" alt="Descripción de la imagen" width="500"/>

### Configuración de la Aplicación

5. Copiar el nombre del servidor desde SQL Server.

<img src="/wwwroot/imgDoc/img6.png" alt="Descripción de la imagen" width="500"/>

6. Cambiar la cadena de conexión en el archivo appSetigsJson del Proyecto.

<img src="/wwwroot/imgDoc/img7.png" alt="Descripción de la imagen" width="500"/>

7. Pegar el nombre del servidor en la cadena de conexión donde dice Server=”DESKTOP-ADJ9ORU\SQLEXPRESS”.

<img src="/wwwroot/imgDoc/img8.png" alt="Descripción de la imagen" width="500"/>

### Ejecución del Proyecto

8. Recopilar la solución.

<img src="/wwwroot/imgDoc/img9.png" alt="Descripción de la imagen" width="500"/>

9. Una vez completados todos los pasos anteriores, podrás ejecutar el proyecto.
10. Si no estas usando VS y estas usando VS Code u otro IDE puedes ejecutar este comando en la raiz del proyecto.

``` bash
dotnet run 
```

> [!IMPORTANT]
> **CREDENCIALES DEL SUPER-USUARIO:** USUARIO: KBJ5001497 - CONTRASEÑA: 123


## **PROCEDIMIENTO DE HOSTEADO Y HOSTING**
<img src="/wwwroot/imgDoc/doc.png" alt="Descripción de la imagen" width="500"/>
Si desea poner la aplicación en marcha en un servidor, puede usar Docker (es necesario tener Docker Desktop). </br></br>

### Siga estos pasos:

</br>

### 1. Completar con exito la parte de **INSTALACIÓN Y CONFIGURACIÓN**

   
> [!IMPORTANT]
> En la seccion **INSTALACIÓN Y CONFIGURACIÓN** se habla sobre cambiar la cadena de conexión en el archivo appSetigsJson del Proyecto</br></br>
Tome en cuenta que se debe poner el **NOMBRE** del servidor en el cual se va a ejecutar la aplicacion(cambielo si es necesario).</br></br>
Para ver como hacerlo vaya a **INSTALACIÓN Y CONFIGURACIÓN > Configuración de la Aplicación**


### 2. Abra **Docker Desktop (para tener los servicios de Docker Activados)** y ejecute en **POWERSHELL** el siguiente comando en la raiz del proyecto, esto creara una imagen de Docker:
``` bash
docker build -t pymes_proyect .
```
<img src="/wwwroot/imgDoc/img10.png" alt="Descripción de la imagen" width="200"/>
<img src="/wwwroot/imgDoc/img11.png" alt="Descripción de la imagen" width="800"/>

### 3. Verifique que la imagen se creo correctamente:
``` bash
docker images
```
<img src="/wwwroot/imgDoc/img12.png" alt="Descripción de la imagen" width="800"/>
<img src="/wwwroot/imgDoc/img13.png" alt="Descripción de la imagen" width="800"/>


### 4. Ponga la imagen en marcha dentro de un contenedor, aqui puede especificar el puerto que se usara, en este caso es el 8888:80
``` bash
docker run -p 8888:80 pymes_proyect
```
<img src="/wwwroot/imgDoc/img14.png" alt="Descripción de la imagen" width="800"/>

### 5. Verifique que el contenedor esta **ACTIVO**:
``` bash
docker ps
```
<img src="/wwwroot/imgDoc/img17.png" alt="Descripción de la imagen" width="800"/>

### 6. Dirijase a **Docker Desktop** y vaya a **CONTENEDORES** en el apartado de **PORT(s)** haga click, esto le llevara al navegador WEB donde podra ver la aplicacion en ejecucución: 
<img src="/wwwroot/imgDoc/img15.png" alt="Descripción de la imagen" width="800"/>
<img src="/wwwroot/imgDoc/img16.png" alt="Descripción de la imagen" width="800"/>

### 7. Ahora que ya verificamos que la imagen funciona, hay que convertir la imagen a un archivo .tar, para poder compartir esta imagen(en este caso, para llevarla al servidor):
   
```bash
docker save -o pymes_proyect.tar pymes_proyect
```

<img src="/wwwroot/imgDoc/img18.png" alt="Descripción de la imagen" width="800"/>

### 8. Ahora tenemos un archivo .tar que podemos compartirlo, o podemos llevarlo en un USB hasta el servidor

> [!IMPORTANT]
> En este punto tambien debemos tener la base de datos restaurada en el servidor, siga los pasos de COMO RESTAURAR LA BDD explicada en **INSTALACIÓN Y CONFIGURACIÓN**


### 9. Una vez que tenemos el archivo .tar en el servidor ejecutamos el comando
    
``` bash
docker load -i pymes_proyect.tar
```

<img src="/wwwroot/imgDoc/img19.png" alt="Descripción de la imagen" width="800"/>

### 10. Ya tenemos la imagen en el servidor para comprobarlo podemos ejecutar:

``` bash
docker images
```

<img src="/wwwroot/imgDoc/img20.png" alt="Descripción de la imagen" width="800"/>

### 11. Ahora ponemos la aplicacion en marcha especificando el puerto (este puerto puede variar ya que debe ser uno que este libre):

``` bash
docker run -p 8888:80 pymes_proyect
```
<img src="/wwwroot/imgDoc/img21.png" alt="Descripción de la imagen" width="800"/>

## **PERSONALIZACIÓN Y CONFIGURACIÓN**
> [!NOTE]
> En esta primera etapa del proyecto, no hemos establecido ninguna configuración específica para la personalización por parte del cliente.</br> Se implementara mas adelante.


## **SEGURIDAD**

> [!WARNING]
> No compartas tus credenciales de inicio de sesión con nadie.

> [!CAUTION]
> Siempre cierra sesión al momento de dejar de usar la aplicación Pymes .

### **DEPURACIÓN Y SOLUCIÓN DE PROBLEMAS**

> [!TIP]
> En caso de que el programa presente errores cierra la aplicación y vuélvela a abrir, caso contrario pueda contactarse con el </br>Ingeniero de Soporte Técnico.

## **GLOSARIO DE TÉRMINOS**

- **ASP.NET Core:** 
  - Framework de desarrollo de aplicaciones web de código abierto desarrollado por Microsoft.
  - [Documentación de ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core)

- **Entity Framework (EF):**
  - ORM (Object-Relational Mapping) de Microsoft para trabajar con bases de datos en .NET.
  - [Documentación de Entity Framework Core](https://learn.microsoft.com/en-us/ef/core)

- **SQL Server:** 
  - Sistema de gestión de bases de datos relacionales desarrollado por Microsoft.
  - [Documentación de SQL Server](https://docs.microsoft.com/en-us/sql/sql-server/)

- **API de Maps de Bing:**
  - API proporcionada por Microsoft para integrar funcionalidades de mapas en aplicaciones.
  - [Documentación de Bing Maps API](https://www.microsoft.com/maps/documentation/)

- **Middleware:** 
  - Software que actúa como intermediario entre aplicaciones y sistemas operativos, redes o bases de datos.
  - [Middleware en ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/)

- **MVC (Modelo-Vista-Controlador):** 
  - Patrón de diseño de software que separa la lógica de la aplicación en tres componentes.
  - [MVC en ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview)

- **DTO (Data Transfer Object):** 
  - Objeto utilizado para encapsular datos y transferirlos entre subsistemas de una aplicación.
  - [Patrones DTO en C#](https://www.c-sharpcorner.com/article/data-transfer-object-design-pattern-in-c-sharp/)

- **CRUD (Create, Read, Update, Delete):** 
  - Operaciones básicas para la manipulación de datos en una base de datos o aplicación.
  - [Concepto de CRUD](https://www.codecademy.com/articles/what-is-crud)

- **API RESTful:** 
  - Interfaz de programación que sigue los principios del estilo arquitectónico REST.
  - [Introducción a API RESTful](https://www.redhat.com/es/topics/api/what-is-a-rest-api)
  
- **Dependency Injection:** 
  - Patrón de diseño que permite la inyección de dependencias en una aplicación.
  - [Inyección de Dependencias en ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)


## **REFERENCIAS Y RECURSOS ADICIONALES**

- [ASP.NET CORE MVC](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)
- [ENTITY FRAMEWORK](https://learn.microsoft.com/en-us/ef/)
- [STACK OVERFLOW](https://stackoverflow.com/)

## **HERRAMIENTAS DE IMPLEMENTACIÓN**

- **Lenguajes de programación:**
  - Los lenguajes de programación utilizados fueron C# y JavaScript.
     
- **Frameworks:**
  - El framework utilizado fue ASP.NET CORE ENTITY FRAMEWORK.

- **APIs de terceros, etc.:**
  - La API utilizada fue la de Bing Maps de Microsoft.

- **Otras tecnologias:**
  - Se uso HTML y CSS.


## **BIBLIOGRAFÍA**

- [ASP.NET CORE MVC](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)
- [ENTITY FRAMEWORK](https://learn.microsoft.com/en-us/ef/)
- [STACK OVERFLOW](https://stackoverflow.com/)
- [ChatGPT](https://stackoverflow.com/)
