# Zoo

Using OOP principals, build out the hierarchical class structure of a zoo within Visual Studio and a digital diagram. There should be at least 3 layers of inheritance with at least 6 different types of animals.

# Visual

![Zoo diagram](https://user-images.githubusercontent.com/17580143/47061582-eefa3d00-d186-11e8-9aa5-44477411f846.png)

# OOP Principals

# Abstraction
Abstract classes and methods are used a a template usually in the more base levels of the hierarchy. Abstract classes cannot be instantiated. </br>
Examples in Zoo: Abstract classes: Animals, Vertebrates, Invertabrates,...

# Inheritance
Inheritance is like a a family tree. You inherit dna, mannerisms, traits, etc from ancestors. The highest class is the base and each class down is a derived class. </br>
Examples in Zoo: Animals is the base class; Vertebrates and Invertabrates are derived from Animals; Reptiles, Birds, Fish, and Mammals are derived from Vertebrates.

# Polymorphism
Polymorphism is the ability to change from base classes. Abstract means the first concrete devrived class is required to ovverride the abstract method or property. Virtual means the property or method can be overridden but is not required to be overridden. </br>
Example in Zoo: Abstract Methods/Properties: IsWarmBlooded (property overridden in Mammals Class and Abstract Fish Class), Abstract Method Fly (method overridien in Rattlesnake Class)

# Encapsulation
Encaplisation is about using access modifiers to stipulate how data in code can be accessed. The three most popular access modifiers are private, protected, and public. </br>
Examples in Zoo: All are public in Zoo

# Interfaces
Interfaces are similar to abstract classes but interfaces can belong to multiple classes and can be implmented by many classes. Interfaces are implemented while abstract classes are overridden.</br>
Examples in Zoo: IAttack and IAmDomesticated are interfaces. IAttack is implemented on the Rattlesnake class. IAmDomesticated is implemented on the Dog class and the Spider class.
