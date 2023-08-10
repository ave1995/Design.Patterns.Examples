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
- A proxy has the same interface as the underlying object
- To create a proxy, simply replicate the existing interface of an object
- Add relevant functionality to the redefined member functions
- Different proxies (communication, logging, caching, etc.) have completely different behaviors
### Proxy vs. Decorator
- Proxy provides and identical interface; decorator provides an enhanced interface
- Decorator typically aggregates (or has reference to) what it is decorating; proxy doesn't have to 
- Proxy might not even be working with a materialized object

## ChainOfResponsibility
- Chain of Responsibility can be implemented as a chain of references or a centralized construct
- Enlist objects in the chain, possibly controlling their order
- Object removal from (e.g., in *Dispose()*)

## Command
- Encapsulate all details of an operation in a separate object
- Define instruction for applying the command (either in the command itself, or elsewhere)
- Optionally define instructions for undoing the command
- Can create composite commands (a.k.a macros)

## Interpreter
- Barring simple cases, an interpreter acts in two stages
- Lexing turns text into a set of tokens, e.g. 3*(4+5) => Lit[3] Star Lparen Lit[4] Plus Lit[5] Rparen
- Parsing tokens into meaningful constructs => MultiplicationExpression[Integer[3], AdditionExpression[Integer[4], Integer[5]]]
- Parsed data can then be traversed

## Iterator
- An iterator specified how you can traverse an object
- An iterator object, unlike a method, cannot be recursive
- Generally, and IEnumerable<T> - returning method is enough
- Iteration works through duck typing - you need a GetEnumerator() that yields a type that has Current and MoveNext()

## Mediator
- Create the mediator and have each object in the system refer to it E.g., in a field
- Mediator engages in bidirectional communication with its connected components
- Components have functions the mediator can call
- Event processing (e.g., Rx) libraries make communication easier to implement

## Memento
- Mementos are used to roll back states arbitrarily
- A memento is simply a token/handle class with (typically) no functions of its own
- A memento is not required to expose directly the state(s) to which it reverts the system
- Can be used to implement undo/redo

## Null Object
- Implement the required interface
- Rewrite the methods with empy bodies > If method is non-void, return default(T), If these values are ever used, you are in trouble
- Supply an instance of Null Object in place of actual object
- Dynamic construction possible > With associated performance implications

## Observer
- Observer is an intrusive approach: an observable must provide an event to subscribe to
- Speacial care must be taken to prevent issues in multithreaded scenarios
- .NET comes with observable collections
- IObserver<T> / IObservable<T> are used in stream processing (Reactive Extensions)

- ## State
- Given sufficient complexity, it pays to formally define possible states and events/triggers
- Can define: State entry/exit behavior, Action when a particular event causes a transition, Guard conditions enabling/disabling a transition, Default action when no transitions are found for an event

- - ## Strategy
- Define an algorithm at a high level
- Define the interface you expect each strategy to follow
- Provide for either dynamic or static composition of strategy in the overall algorithm
