Object-Oriented Programming (OOP) is a programming paradigm based on the concept of "objects,"
which can contain data in the form of fields (often called properties or attributes) 
and code in the form of procedures (often called methods).

Modualrity
Reusability

1. ENCAPSULATION : boundning of data and methods inside a class, hiding unwanted members from others
public class Car
{
    private string model; // private field
    public Car(string model)
    {
        this.model = model;
    }
    public void Drive()
    {
        Console.WriteLine($"{model} is driving.");
    }
}
2. ABSTRACTION : hiding the complexity
3. INHERITANCE : mechanism to inherit properties of a parent class to a child class
4. POLYMORPHISM : interface's child classes who have different meaning for each method 

FIELDS AND PROPERTIES :
----------------------

Properties provide a way to control the access to the data thru { get; set; }
Fields don't let you write logic when a value saved/retreived 
Auto Implemented property public int MyProperty { get; set; }

Directly declared in a class
can have access specifiers (public, private, protected)
private by default

CONSTRUCTOR : 
------------
special method used to initialise the object of a class,name is same as class
invoked when an object is created

use :   to set the inital values for fields/properties
        to perform any set of operations when an object is created

types : default, parameterized
        static  :   called only once for the entire class(not every time an obj is called)
                    to initialze static variables

        private :   prevent the creation of objects
                    in singleton patterns where only one definition is allowed
                    (A private constructor is used to restrict instantiation of a class from outside the class.
                     It is typically used in singleton patterns where only one instance of a class
                    is allowed or in utility classes where you don’t want any objects of the class to be created.)
        copy    :   used to create a new copy of an existing object, creating duplicates

constructor overloading is possible in C#


Default Constructor: Initializes fields with default values.
Parameterized Constructor: Initializes fields with specific values passed by the user.
Static Constructor: Initializes static fields and runs only once for the class.
Private Constructor: Prevents object creation from outside the class (useful for singleton pattern).
Copy Constructor: Creates a new object by copying the values from another object.
Constructor Overloading: Allows multiple constructors with different parameter types and counts.

INTERFACE :
----------

tells what should be there but now how. how is defined in the class
KEY POINTS OF AN INTERFACE : 
---------------------------

1.  No Implementation: Interfaces only define the signature of members
    (methods, properties, etc.) without including the actual implementation.
2.  Multiple Inheritance: A class can implement more than one interface, allowing for multiple inheritance.
3.  Polymorphism: Interfaces allow classes to be used interchangeably, supporting polymorphism.
4.  Access Modifiers: Members of an interface are implicitly public,
    and you cannot use access modifiers like private, protected, etc., inside an interface.
5.  No Fields: An interface cannot contain fields (variables).
6.  Default Members in C# 8+: Since C# 8.0, interfaces can have default implementations for methods.

WHY USE INTERFACES?
-------------------

1.  Loose Coupling: Interfaces allow for loose coupling between components,
    making it easier to modify or replace implementations without affecting other parts of the system.
2.  Multiple Implementations: Different classes can implement the same interface in different ways,
    providing flexibility.

3.  Testability: Interfaces make unit testing easier by allowing dependencies to be replaced with mock implementations.
 
SUMMARY : 
Interface defines a contract that classes or structs must follow.
Implementation must be provided by the classes or structs that implement the interface.
It promotes polymorphism, multiple inheritance, and loose coupling.

FUNCTION/METHOD OVERLOADING :
---------------------------
multiple methods in the same class with the same name but different parameters


- to implement polymorphism
- allows derived(child) class to modify or extend behaviour of base(parent) class
- runtime method overloading

FUNCTION/METHOD OVERRIDING :
---------------------------
In C#, the virtual and override keywords are used to implement polymorphism,
which allows derived classes to modify or extend the behavior of base class methods.
These keywords are key elements in runtime method overriding, enabling flexibility and
customization in object-oriented programming.

- virtual keyword : to mark something as overrideable by the derived class 
The virtual keyword is used to indicate that a method, property, or event
can be overridden by any derived class. A method marked as virtual in the base class
provides a default implementation, but derived classes can change this behavior by overriding it.
Key Points:
The virtual method provides a base-level implementation.
Derived classes can override the virtual method using the override keyword.
If a method is not marked virtual, it cannot be overridden in derived classes.


OVERRIDE KEYWORD
The override keyword is used in a derived class to override a base class method (or property, event)
that is marked as virtual or abstract. This allows the derived class to
change the behavior of the inherited method.

Key Points:
The override keyword is used in a derived class to provide a new
implementation for an inherited virtual or abstract method.
The base class method and the overriding method in the derived class
must have the same signature (return type and parameters).
The overriding method replaces the base class method.

Important Points

Polymorphism: The combination of virtual and override allows for polymorphic behavior. 
This means that the method to be called is determined at runtime, depending on the type of the object.
Accessing the Base Class Implementation: Inside an overriding method, 
you can call the base class version of the method using base.MethodName() if needed.
Non-Virtual Methods: If a method is not marked as virtual, it cannot be overridden in derived classes.

Summary : 
virtual keyword allows a method to be overridden in derived classes.
override keyword is used in the derived class to provide a new implementation of a virtual method.
Together, they enable runtime polymorphism, allowing different classes to implement the same method in different ways.

DELEGATES :
-----------
ABSTRACT CLASS : 

meant to be inhertited 
cannot create an bject 
can have astract members with no impletmentaiotn 
unlike interfaces, can have methods with body
when you wanna share code among closely related classes
