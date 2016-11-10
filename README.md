# PlanetaryMotion
# Infraestructura
A nivel de infraestructura la solución esta pensada para ser usada en dos servidores distintos. En el primer servidor debería estar instalado un Web Server IIS con los correspondientes módulos necesarios para correr aplicaciones ASP.NET.
En lo que respecta a la base de datos, inicialmente la solución fue diseñada para funcionar con motores MySQL aunque podría funcionar con cualquier tipo de base de datos debido a la existencia de un ORM (Entity Framework 6) utilizada para los diversos accesos a datos.El servicor de MySQL actualmente es un Linux Debian con MySql 5.5 provisto por Google Cloud Platform (GCP).
# Arquitectura
La arquitectura usada es una arquitectura orientada a servicios (http://microservices.io/) y se encuentra desarrollada con .NET framework 4.6. Asimismo se esta utilizado un Service Locator (AutoFac: https://autofac.org/) a fin de proveer la resolución de dependencias necesarias a fin de reducir el acoplamiento entre las diferentes clases. La exposición de los diferentes recursos HTTP se realizan a través del framework WebApi2.
# Artefactos
La aplicación cuenta básicamente con dos artefactos, el primero es la aplicación Web, donde a través de una serie de etapas se pasa a responder las diferentes necesidades básicas como así también la interoperatibilidad correspondiente con otras aplicaciones si lo quieren.
El otro componente, es un proceso batch que permite hacer la carga historica de datos dentro de la base de datos de la aplicación.
# Unit Testing
El unit testing realizado básicamente se realizo sobre la parcialidad matemática del proyecto a fin de poder verificar el core del sistema. La Librería utilizada para esta serie de chequeos fue xUnit (https://xunit.github.io/).
# Frameworks
Los frameworks mas importantes utilizados en la aplicación son los que se detallan a continuación.
* Autofac (https://autofac.org/)
* Autofac para integración con WebAPI (https://autofac.org/)
* CommandLineParser (https://commandline.codeplex.com/)
* EntityFramework (https://www.asp.net/entity-framework)
* NewtonSoft (http://www.newtonsoft.com/json)
* Swagger (o Swashbuckle) (http://swagger.io/)
* xUnit (https://xunit.github.io/)

# Dependencias externas
Debido a los issues existentes de compatiblidad entre MySQL 5.x y Entity Framework en la funcionalidad de migración de base de datos se decidió utilizar la solución ya establecida en el repositorio destinada a tal fin (https://github.com/ldvalido/DDS-ORM).
# SonarQube
Asimismo la aplicación cuenta con una instancia dedicada de SonarQube en la url: http://104.196.209.111:9000/.
Esta aplicaición ejecuta las métricas de código correspondientes del código fuente. Cabe mencionar que dicha instancia se encuentra hosteada en GCP. A fin de poder correr el motor de SonarQube se configuro el Running Environment de Java 8 y al mismo se le agrego el plugin correspondiente para C#.
# Swagger
Asimismo a través de la url http://104.196.209.111, es posible realizar la navegación de los diferentes recursos API expuestos en la aplicación.
