# Azure AI

We create our first console for tests:
```
dotnet new console -n prueba
```

After enabling unit tests to the project, add the references:
```
dotnet add pruebaTest/pruebaTest.csproj reference prueba/prueba.csproj
```

Nuget needed for unit testing:
```
https://api.nuget.org/v3/index.json
```

Libraries used in this project:
```
# These are not compatible with net8.0
dotnet add package Figgle --version 0.5.1
dotnet add package ConsoleTables --version 2.4.2
```
More information:
 * https://github.com/drewnoakes/figgle
 * https://github.com/khalidabuhakmeh/ConsoleTables

# Resources

## C#

1. Escritura del primer código con C# (Introducción a C#, parte 1)
 * https://learn.microsoft.com/es-es/training/paths/get-started-c-sharp-part-1/

2. Creación y ejecución de aplicaciones de consola de C# sencillas (Introducción a C#, parte 2)
* https://learn.microsoft.com/es-es/training/paths/get-started-c-sharp-part-2/

3. Adición de lógica a aplicaciones de consola de C# (Introducción a C#, parte 3)
* https://learn.microsoft.com/es-es/training/paths/get-started-c-sharp-part-3/

4. Trabajo con datos de variables en aplicaciones de consola de C# (Introducción a C#, parte 4)
* https://learn.microsoft.com/es-es/training/paths/get-started-c-sharp-part-4/

5. Creación de métodos en aplicaciones de consola de C# (Introducción a C#, parte 5)
* https://learn.microsoft.com/es-es/training/paths/get-started-c-sharp-part-5/

6. Depuración de aplicaciones de consola de C# (Introducción a C#, parte 6)
* https://learn.microsoft.com/es-es/training/paths/get-started-c-sharp-part-6/

Compilación de aplicaciones web con ASP.NET Core para principiantes
* https://learn.microsoft.com/es-es/training/paths/aspnet-core-web-app/

6. Clasificación de rocas espaciales mediante Python e inteligencia artificial
* https://learn.microsoft.com/es-es/training/paths/classify-space-rocks-artificial-intelligence-nasa/


