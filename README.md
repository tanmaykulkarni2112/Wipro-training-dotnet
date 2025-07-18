# Hello World Program

```c#
Console.WriteLine("HELLO WORLD");
// Console.Write("HELLO WORLD IN SAME LINE"); the printed line will be in the same line
Console.ReadLine();
```

# General Structure

```c#
using System

namespace Folder{ // This enables us to write classes within same namespace

    class fileName{ // DEFAULT IS program.cs

     static void main(String[] args) {
        // LOGIC OF THE PROGRAM
     }
    }
}
```

Inheritance and use of the base keyword

COMPILETIME AND RUNTIME POLYMORPHISM

access modifier | accessibility

private | only within the containing class
public | anywhere, no restriction
protected | Within the containing types, and the types derived from the containing type
internal | anywhere within the containing assembly
protected internally | anywhere within the containing assembly and from within a dervied class in any another assembly
