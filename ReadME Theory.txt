******************************************************************************************
1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess
grundläggande funktion

The Stack and the Heap:
Definition and differences:

Stack: It's a region of memory where value types are stored. It's managed for you by the CLR (Common Language Runtime) and grows and shrinks automatically.
Heap: It's a region of memory where reference types are stored. Memory allocation and deallocation are managed by the garbage collector.

******************************************************************************************

2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?

Value Types and Reference Types.
Definition of value types and reference types:

Value Types: These are data types where the variable stores the actual data. Examples are all primitive data types like int, double, bool, char, struct, etc.
Reference Types: These are data types where the variable stores the reference (or memory address) to the data. Examples include string, List<T>, arrays, and custom classes.
Examples:

Value Types: int age = 25;, double height = 5.9;, bool isActive = true;
Reference Types: string name = "John";, List<int> numbers = new List<int>();, var person = new Person();

Differences:

Memory Storage: Value types are stored in the stack, while reference types are stored in the heap.
Assignment Behavior: Value types create a copy of the value when assigned to another variable, whereas reference types point to the same memory location.
Passing to Methods: Value types are passed by value, meaning a copy is passed to methods. Reference types are passed by reference, meaning the method can modify the original data.

******************************************************************************************

3. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den
andra returnerar 4, varför?

Method: 1
public int ReturnValue()
{
    int x = new int();
    x = 3;
    int y = new int();
    y = x;
    y = 4;
    return x;
}

Method: 2
public int ReturnValue2()
{
    MyInt x = new MyInt();
    x.MyValue = 3;
    MyInt y = new MyInt();
    y = x;
    y.MyValue = 4;
    return x.MyValue;
}


Answer: 

In the method 1 both x and y are VALUE types and their store their values in separate memory locations, so changing y does not affect the x.
Method calls for returning x value which is 3.

In the method 2, x and y are REFERENCE types so they can point to the same object in the memory and changing y does affect the x since they are referencing the same thing.
That's why it does display new value even on x which is 4.

******************************************************************************************

Task 5 & 6

Iterative functions are more memory-efficient than recursive ones because they don't create new stack frames for each iteration. 
In contrast, recursive functions, like RecursiveOdd, RecursiveEven, and the Fibonacci function, 
consume more memory with increasing input values due to the creation of new stack frames for each recursive call. 

Among the functions implemented, the recursive Fibonacci can be particularly memory-intensive for larger inputs.



******************************************************************************************