Pilot C# MVC5 (EF6, AngularJS, RequireJS)
============================
Pilot project integrating MVC5, Entity Framework 6 and front-end based on requirejs and angularjs with lazy load. I'll talk about each part but I'll keep focusing on AngularJS + RequireJS. It is important to understand javascript and closure before going on.

## Roadmap
1. Purpose
2. Basic aproaching of modules
  1. DI (*Dependency injection*)
  2. ~~ASP MVC5~~
    * ~~What is it?~~
    * ~~What does it do?~~
    * ~~How do I configure it?~~
    * ~~Dependency injection with MVC5~~
  3. ~~Javascript~~
    * ~~First steps~~ 
    * ~~Closures~~
    * ~~Best practices~~
  4. ~~Javascript (AngularJS + RequireJS)~~
    * ~~First steps~~ 
    * ~~Best pratices~~
  5. ~~WCF~~
  6. ~~Services~~
  7. ~~Entity Framework 6~~
  8. ~~Entities (POJO)~~
3. ~~Getting started~~
  1. ~~How to modulate your project~~
  2. ~~Which files should be created~~
  3. ~~How to implement lazy load of controllers and services (factories)~~
4. ~~Contributors~~
5. ~~Come together~~


### Purpose
The idea behind this project is to spread part of my "old bag" and the new knowledge which I've learnt in the last few days. I'd created a challenge for myself and that was the result. The project consist in build a metodology of development with angularjs, in which one I could notice the performance of application and how faster it can be to develop web projects with SPA (*Single Page Application*).
Considering that SPA works with partial rendering, we could aproach in two ways.
* Load your whole application at the first access and show content on demand
* Load your application on demand as long as it is necessary.

For this project, I've taken the second path.

### Basic aproaching of modules
Before we start properly it (I love code first also), we need to understand some basic topics. I'll just give basic concepts about each one. But it is important understand it with your heart. I used to say that everything becomes easy after total understanding of the engines.

### Dependency injection
Firstly, I'll give you some references about the subject and afterwards I'll give my own idea about it. I think that they are pretty similar, but my one will be more condensed. 
[Roadmap of DI, according to MSDN](http://msdn.microsoft.com/en-us/library/dn223671%28v=pandp.30%29.aspx)
[Dependency injection, MSDN](http://msdn.microsoft.com/en-us/library/dn178469(v=pandp.30).aspx)
[Dependency injection with Unity](http://msdn.microsoft.com/en-us/library/dn178463(v=pandp.30).aspx)
So, DI comes from IoC (*Inversion of Control*). IoC basically means that none object can instantiate your dependencies. Then, it can be implemented by many ways, one of them it is DI. We have a lot of frameworks and libraries with DI implementation such as Spring, Dagger, Google Guice - [for Java](https://keyholesoftware.com/2014/02/17/dependency-injection-options-for-java/) -, Unity, Spring.NET, Castle Windsor - [for .NET](http://www.hanselman.com/blog/ListOfNETDependencyInjectionContainersIOC.aspx).
In this project we're going to use Unity.
