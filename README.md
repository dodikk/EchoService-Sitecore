EchoService-Sitecore
====================

A simple echo service prototype for the web service based on the Sitecore instance. It can be used as a template for developing more complex modules.


##Rationale

Web API modules are an important **extension point** of the Sitecore CMS. Having a well defined RESTful API is the easiest way to provide data for mobile applications or any other third-party clients. Still, it may be a challeging task for some beginners.

This **tutorial** will cover the basics of creating **Web API service** for Sitecore. As a result, you'll get a minimalistic "hello world" project and some instructions on deploying it.




##Getting Started
In order to add your Web API to Sitecore you should 

1. Put the **assembly** of your module to the ```bin``` directory of your instance
![Image 1 : Instance bin directory](https://github.com/dodikk/EchoService-Sitecore/raw/master/readme-screenshots/1-InstanceBin.png)
2. Put the **config** file to the ```appConfig\include``` directory
![Image2 : Config files directory](https://github.com/dodikk/EchoService-Sitecore/raw/master/readme-screenshots/2-ConfigDir.png)


## Config File Requirements
A typical web API module is implemented using the .NET MVC mapping mechanism. The ```initialize``` pipeline should be used in order to enable this mapping.

```
You can find out more by reading chapter "3.2.1  Initialize" 
of the "Sitecore Pipelines" reference document.
```
<http://sdn.sitecore.net/Reference/Sitecore%206/Sitecore%20Pipelines.aspx>


Here is an example of the minimal config file for your module
```xml
<?xml version="1.0"?>
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <pipelines>
      <initialize>
        <processor type="HWWebApi.InitializeRoutes,HWWebApi"
                   patch:after="*[@type='Sitecore.Mvc.Pipelines.Loader.InitializeRoutes, Sitecore.Mvc']" />
      </initialize>
    </pipelines>
  </sitecore>
</configuration>
```




# To be Continue...
The tutorial is not complete yet.