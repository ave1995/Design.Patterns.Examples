# Design Patterns Examples 

I made examples of design patterns according to the course with minor improvements 

## The SOLID Design Principles 

### Single Responsibility Principle
- A class should only have one reason to change
- *Separation of concerns* - different classes handling different, independent tasks/problems
### Open-Closed Principle
- Classes should be open for extension but closed for modification
### Liskov Substitution Principle
- You should be able to substitute a base type for a subtype
### Interface Segregation Principle
- Don't put too much into an interface; split into separate interfaces
- *YAGNI* - You Ain't Going to Need It
### Dependency Inversion Principle
- High-level modules should not depend upon low-level ones; use abstractions

## Builder
- A builder is a separate component for building an object
- Can either give builder a constructor or return it via a static function
- To make builder fluent, return this
- Different facets of an object can be built with different builders working in tandem via a base class

## Factories
- A factory method is a static method that creates objects
- A factory can take of object creation
- A factory can be external or reside inside the object as an inner class
- Hierarchies of factories can be used to create related objects

## Prototype
- To implement a prototype, partially construct an object and store it somewhere
- Clone the prototype
- Implement your own deep copy functionality; or 
- Serialize and desirialize
- Customize the resulting instance

## Adapter
- Implementing an Adapter is easy
- Determine the API you have and the API you need
- Create a component which aggregates (has reference to, ...) the adaptee
- Intermediate representations can pile up: use caching and other optimizations

## Bridge
- Decouple abstraction from implementation
- Both can exist as hierarchies
- A stronger form of encapsulation

## Composite
- Objects can use other objects via inheritance/composition
- Some composed and singular objects need similar/identical behaviors
- Composite design pattern lets us treat both types of objects iniformly
- C# has special support for the *enumeration* concept
- A single object can masquerade as a collection with *yield return this;*

## Decorator
- A decorator keeps the reference to the decorated object(s)
- May or may not proxy over calls
- Exists in a *static*  X<Y<Foo>> Very limited due to inability to inherit from type parameters

## Facade
- Build a Facade to provide a simplified API over a set of classes
- May wish to (optionally) expose internals through the facade
- May allow users to 'escalate' to use more complex APIs if they need to

## Flyweight
- Store common data externally
- Define the idea of 'ranges' on homogeneous collections and store data related to those ranges
- .NET string interning is the Flyweight pattern

## Proxy
### Summary
-
-
-
### Proxy vs. Decorator
- Proxy provides and identical interface; decorator provides an enhanced interface
- Decorator typically aggregates (or has reference to) what it is decorating; proxy doesn't have to 
- Proxy might not even be working with a materialized object
