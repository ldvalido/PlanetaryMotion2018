# PlanetaryMotion
# Infraestructura
A nivel de infraestructura la solución esta pensada para ser usada en dos servidores distintos. En el primer servidor debería estar instalado un Web Server IIS con los correspondientes módulos necesarios para correr aplicaciones ASP.NET.
En lo que respecta a la base de datos, inicialmente la solución fue diseñada para funcionar con motores MySQL aunque podría funcionar con cualquier tipo de base de datos debido a la existencia de un ORM (Entity Framework 6) utilizada para los diversos accesos a datos.
# Arquitectura
La arquitectura usada es una arquitectura orientada a servicios (http://microservices.io/). Asimismo se esta utilizado un Service Locator (AutoFac: https://autofac.org/) a fin de proveer la resolución de dependencias necesarias a fin de reducir el acoplamiento entre las diferentes clases. 
# Artefactos
La aplicación cuenta básicamente con dos artefactos, el primero es la aplicación Web, donde a través de una serie de etapas se pasa a responder las diferentes necesidades básicas como así también la interoperatibilidad correspondiente con otras aplicaciones si lo quieren.
El otro componente, es un proceso batch que permite hacer la carga historica de datos dentro de la base de datos de la aplicación.
# Frameworks
Los frameworks mas importantes utilizados en la aplicación son los que se detallan a continuación.
Autofac
Autofac para integración con WebAPI
CommandLineParser
EntityFramework
NewtonSoft
Swagger (o Swashbuckle)
xUnit
# SonarQube
Asimismo la aplicación cuenta con una instancia dedicada de SonarQube en la url: http://104.196.209.111:9000/.
Esta aplicaición ejecuta las métricas de código correspondientes del código fuente. Cabe mencionar que dicha instancia se encuentra hosteada en la nube de Google Cloud Platform.
# Swagger
Asimismo a través de la url http://104.196.209.111, es posible realizar la navegación de los diferentes recursos API expuestos en la aplicaición.
