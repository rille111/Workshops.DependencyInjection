# Workshop - Upgrading legacy application to use Dependency Injection

There's no step by step guide here, just a lot of projects to help drive a workshop/demo.

# Statements

* Using 'new' is bad. It is so 1990.
* Using Container.GetMe<IAnimal>() is better, but still bad.
* Having class constructors get you an IAnimal, is king!

# Glossary

## DI = Dependency Injection 
Basically means that you should not create a difficult-to-discover dependencies inside a class! 
Therefore, var myDog = new Dog() is bad.
Therefore, you should INJECT dependencies to classes that need them. Prefer the constructor.

## IoC = Inversion of Control
Basically, it's the concept that you put the control of what implementations are used in a higher level. On a policy kind of level.
Like in the program startup.

## Container = The container that give you the magic

The 'container' is the place where you have all the rules, saying that for example "When you encounter an 'IAnimal' use a 'Dog'".
Before using a container, you 'Register' all these rules. And then you resolve an abstract 'IAnimal', not the implementation 'Dog' by itself.
You use the container to resolve your dependencies.
The magic is telling your .NET applications to automagically resolve dependencies when it encounters them, so that you dont have to work with the container directly.