# Creational Design Patterns


## Author: Prodan Rodica, FAF-211

----

## Objectives:
1. Study and understand the Creational Design Patterns.
2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.
3. Use some creational design patterns for object instantiation in a sample project.

## Laboratory notes


* I tried to implement four creational design patterns: ``` Singleton, Factory, Prototype and Builder.```

## Implementation:

### 1. Singleton design pattern:
The ```ProductDatabase``` class uses the Singleton pattern. It ensures that there is only one instance of the ```ProductDatabase``` class by providing a private constructor and a static ```GetInstance``` method that creates an instance if one doesn't exist or returns the existing instance.

### 2. Factory method design pattern:
The Factory Method pattern is used in the ```IProductFactory``` interface and the ```ConcreteProductFactory``` class. The interface defines a method ```CreateProduct```, which is implemented by the factory class to create products.


### 3. Builder design pattern:
The Builder pattern is implemented with the ```ProductBuilder``` class. It provides methods for setting various attributes of a ```Product``` object and a ```Build``` method for creating the product with the specified attributes.


### 4. Prototype design pattern:
The Prototype pattern is implemented in the ```Product``` class. The ```Product``` class implements the ```ICloneable``` interface and provides a ```Clone``` method that creates a new instance of a ```Product``` with the same values as the original. It allows me to create new ```Product``` instances that are copies of existing products without exposing the details of the cloning process. 



Each of these design patterns serves its intended purpose and is improving code structure, maintainability, and flexibility.


