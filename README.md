
# Portfolio Assignment - C# Projects

This repository contains various projects and exercises related to C# and .NET development. Each project demonstrates different concepts such as object-oriented programming, interfaces, operator overloading, and polymorphism.

## Project Files

### 1. Polymorphism.cs
- **Description**: This project demonstrates the concept of polymorphism in C#. The `Employee` class implements the `IQuittable` interface, which includes a `Quit()` method. In the main program, polymorphism is demonstrated by treating an `Employee` object as an `IQuittable` object and calling the `Quit()` method.
- **Key Concepts**: Polymorphism, Interfaces, and Method Overriding.
- **File**: [Polymorphism.cs](Polymorphism.cs)

### 2. Operator Assignment.cs
- **Description**: This project focuses on operator overloading. The `Employee` class has overloaded `==` and `!=` operators to compare two `Employee` objects based on their `Id`. It also overrides the `Equals` and `GetHashCode` methods to ensure proper comparison behavior.
- **Key Concepts**: Operator Overloading, Overriding Methods.
- **File**: [Operator Assignment.cs](Operator%20Assigment.cs)

### 3. IQuittable.cs
- **Description**: The `IQuittable` interface defines a method `Quit()` that is implemented in the `Employee` class. This is part of the polymorphism example, where the `Employee` class inherits from the `IQuittable` interface.
- **Key Concepts**: Interfaces, Polymorphism.
- **File**: [IQuittable.cs](IQuittable.cs)

### 4. Portfolio Assignment Submission.cs
- **Description**: This file contains descriptions of two MVC projects, `Car Insurance` and `NFL Stats`. These projects focus on web development using the .NET framework and cover topics such as data visualization and quote calculation using business logic.
- **Key Concepts**: MVC Web Applications, Entity Framework, Code First.
- **File**: [Portfolio Assignment Submission.cs](Portfolio%20Assignment%20Submission.cs)

### 5. .gitattributes
- **Description**: This file ensures consistent line endings across different operating systems by normalizing line endings.
- **File**: [.gitattributes](.gitattributes)

## How to Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run each project individually to see the output.
