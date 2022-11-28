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
