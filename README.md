# CodeStandards
## **Code Standars / Normas para Código Fuente** 

This demo is used to demonstrated some rules of codifying for a team of development.  This project are only suggestions which can be improved during its progress.  NOTHING IS WRITTEN IN STONE 

Este es un proyecto de demostración para mostrar algunas reglas de codificación para un equipo de desarrollo. Este proyecto puede ser mejorado su progreso. NADA ESTA ESRITO EN PIEDRA.

This project is about a calculator for two values and one operator (+,-,*,/).  It was built using unit testing and integration testing. 

Este proyecto es acerca de una calculdora para dos valor y un operador (+,-,*,/). Este fue contruido empleando pruebas unitarias y pruebas de integracion. 

### **Start / Inicio**

1.- Create a dotnet solution / Crear una solución en .net:

- _dotnet new sln_

2.- Create projects (library,tests, and services) / Crear los proyectos (biblioteca,pruebas y servicios):

- _dotnet new classlib -f net8.0 -n Library_
- _dotnet new xunit -f net8.0 -n Tests_
- _dotnet new webapi  -f net8.0 --use-controllers -o Services_

3.- Link them to the solucion / Vincular los proyectos a la solución:

- _dotnet sln add .\Library\Library.csproj_
- _dotnet sln add .\Tests\Tests.csproj_
- _dotnet sln add .\Services\Services.csproj_

4.- Declare references among proyects / Declarar las dependencias entre proyectos

-  In Tests' folder / en la carpeta de Pruebas: _dotnet add reference ..\Library\Library.csproj_
-  In Services' folder / en la carpeta de Servicios: _dotnet add reference ..\Library\Library.csproj_

### **Run / Ejecutar**

#### *Global Run / Ejecución global :*

Execute these command when Library's project has been modified.

Ejecutar estos comando cuando el proyecto de la Libreria haya sido modificada.

- dotnet build  | dotnet test  .\Tests\ --nologo --verbosity:quiet

#### *Optional / Optional :*

 

1.- For unit testing / Para las pruebas unitarias:

- In Tests' folder / en la carpeta de Pruebas: _dotnet test --nologo --verbosity:quiet_

2.- For Services / Para Servicios:

- In Services' folder / En la carpeta de servicios: _dotnet run_

3.- For Build the solution / Para compilar la solución:

- In Solution´s folder / En la carpeta de la solución: _dotnet build_




