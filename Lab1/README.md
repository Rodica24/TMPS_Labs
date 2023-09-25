# SOLID PRINCIPLES
## Author: Prodan Rodica, FAF - 211

``SOLID`` is an acronym for the first five object-oriented design, which help us to create a well-structured code, modular, and allows for easy extension and maintenance. In this laboratory work I've implemented an easy project that follows the SOLID principles.

### 1. Single Responsibility Principle
Each class has a single and well-defined responsibility.
Each geometric shape class has the responsibility of representing and calculating properties of their respective shapes and `GeometryPrinter` class is responsible for printing the shape's information.

### 2. Open Closed Principle
This principle suggests that software entities (classes, modules, functions) should be open for extension but closed for modification. In my code I can add new shapes without modifying the existing `GeometryPrinter` or other shape classes, but simply create a new class that implements the `IShape` interface. 

### 3. Liskov Substitution Principle
This principle states that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. My code follows this principle, as all shape classes implement the `IShape` interface and can be used interchangeably.

### 4. Interface Segregation Principle
This one says that clients should not be forced to depend on interfaces they don't use. I used two separate interfaces: `IShape` and `IShapePrinter`, each serving a distinct purpose. Therefore, `IShape` defines methods related to shape calculations, while `IShapePrinter` defines a method for printing shapes and classes can implement only the relevant interface.

### 5. Dependency Inversion Principle
Thsi principle states that entities must depend on abstractions, not on concretions. In my project: 

High-level modules depend on abstractions: The `Program` class depends on the `IShapePrinter` abstraction, which is a high-level module, and it doesn't depend on concrete implementations.

Low-level modules depend on the same abstractions: The `GeometryPrinter` class, which is a low-level module responsible for printing shapes, also depends on the `IShapePrinter` abstraction. This means that both high-level and low-level modules depend on the same abstraction.

Abstractions do not depend on details: The `IShapePrinter` abstraction does not depend on the details of concrete implementations. It provides a generic way to print shapes.