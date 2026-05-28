# C# COMPLETE DATA TYPES GUIDE

*For: Freshers | Java Migrants | JavaScript Migrants*

---

# Table of Contents

1. [Before You Begin — Key Mindset Shifts](#before-you-begin--key-mindset-shifts)
2. [Section 1 — How Typing Works in C#](#section-1--how-typing-works-in-c)

   * [1A. Static Typing](#1a-static-typing-default-in-c)
   * [1B. var — Type Inferred at Compile Time](#1b-var--type-inferred-at-compile-time)
   * [1C. dynamic — Type Checked at Runtime](#1c-dynamic--type-checked-at-runtime)
3. [Section 2 — Value Types](#section-2--value-types-stored-directly-in-stack-memory)

   * [2A. Boolean](#2a-boolean)
   * [2B. Integer Family](#2b-integer-family--choose-the-right-size)
   * [2C. Decimal / Floating-Point Family](#2c-decimal--floating-point-family)
   * [2D. Char](#2d-char)
   * [2E. Struct](#2e-struct--custom-value-type)
   * [2F. Enum](#2f-enum--named-constants)
4. [Section 3 — Reference Types](#section-3--reference-types-stored-in-heap-memory)

   * [3A. String](#3a-string)
   * [3B. Object](#3b-object--the-root-of-everything)
   * [3C. Array](#3c-array--fixed-size-collection)
   * [3D. Class](#3d-class)
   * [3E. Interface](#3e-interface)
   * [3F. Delegate](#3f-delegate--reference-to-a-method)
5. [Section 4 — Nullable Types](#section-4--nullable-types--value-types-that-can-hold-null)
6. [Section 5 — Collection Types](#section-5--collection-types--dynamic-size-data-structures)

   * [5A. List<T>](#5a-listt--dynamic-array-most-used)
   * [5B. Dictionary<TKey, TValue>](#5b-dictionarytkey-tvalue--key-value-pairs)
   * [5C. HashSet<T>](#5c-hashsett--unique-values-only)
   * [5D. Queue<T>](#5d-queuet--first-in-first-out-fifo)
   * [5E. Stack<T>](#5e-stackt--last-in-first-out-lifo)
   * [5F. LinkedList<T>](#5f-linkedlistt--node-based-list)
7. [Section 6 — Modern C# Types](#section-6--modern-c-types-c-7-8-9-10-11)

   * [6A. Tuple](#6a-tuple--group-multiple-values-quickly)
   * [6B. Record](#6b-record--immutable-data-model)
   * [6C. Anonymous Type](#6c-anonymous-type)
   * [6D. Span<T> and ReadOnlySpan<T>](#6d-spant-and-readonlyspant--high-performance-slicing)
8. [Section 7 — Boxing and Unboxing](#section-7--boxing-and-unboxing)
9. [Section 8 — Type Conversion](#section-8--type-conversion)
10. [Section 9 — Pointer Types](#section-9--pointer-types-unsafe-code--rarely-needed)
11. [Section 10 — Memory: Stack vs Heap](#section-10--memory-stack-vs-heap-visual-summary)
12. [Section 11 — Quick Reference Cheat Sheet](#section-11--quick-reference-cheat-sheet)
13. [Section 12 — Interview Must-Know Points](#section-12--interview-must-know-points)

---

# Before You Begin — Key Mindset Shifts

```csharp
// ► Coming from JavaScript?
//   JS is DYNAMICALLY typed  →  C# is STATICALLY typed
//   In JS you write:  let x = 10;   then x = "hello";  ✔ fine
//   In C# you MUST declare a type and STICK with it (usually)

// ► Coming from Java?
//   Good news: C# syntax feels very familiar!
//   Differences: 'decimal' type (Java has none), 'var' keyword,
//   nullable types with '?', and 'dynamic' keyword are C#-specific.

// ► Fresher?
//   Think of a data type as a "box label".
//   Before storing something, C# wants to know WHAT KIND of
//   thing goes inside the box — a number? text? true/false?
```

---

# Section 1 — How Typing Works in C#

## 1A. Static Typing (default in C#)

```csharp
int salary = 50000;
string name = "Ravi";
```

---

## 1B. var — Type Inferred at Compile Time

```csharp
var city  = "Pune";
var age   = 25;
var price = 9.99;
```

---

## 1C. dynamic — Type Checked at Runtime

```csharp
dynamic data = 100;
data = "Hello";
data = true;
data = 3.14;
```

---

# Section 2 — Value Types (stored directly in STACK memory)

## 2A. Boolean

```csharp
bool isLoggedIn = true;
bool hasPermission = false;
```

---

## 2B. Integer Family — Choose the right size

| Type   | Size    | Range             | Use Case      |
| ------ | ------- | ----------------- | ------------- |
| byte   | 1 byte  | 0 to 255          | pixel values  |
| sbyte  | 1 byte  | -128 to 127       | temperature   |
| short  | 2 bytes | -32,768 to 32,767 | small counts  |
| ushort | 2 bytes | 0 to 65,535       | ports         |
| int    | 4 bytes | ±2 billion        | default       |
| uint   | 4 bytes | 0 to 4 billion    | IDs           |
| long   | 8 bytes | huge              | phone numbers |
| ulong  | 8 bytes | huge positive     | astronomy     |

```csharp
int employeeId = 101;
long mobileNumber = 9876543210L;
```

---

## 2C. Decimal / Floating-Point Family

| Type    | Size     | Use Case |
| ------- | -------- | -------- |
| float   | 4 bytes  | graphics |
| double  | 8 bytes  | science  |
| decimal | 16 bytes | finance  |

```csharp
float percentage = 99.5f;
double piValue = 3.14159;
decimal accountBal = 199999.99m;
```

---

## 2D. Char

```csharp
char grade = 'A';
char heart = '\u2665';
```

---

## 2E. Struct — Custom Value Type

```csharp
struct Point
{
    public int X;
    public int Y;
}
```

---

## 2F. Enum — Named Constants

```csharp
enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}
```

---

# Section 3 — Reference Types (stored in HEAP memory)

## 3A. String

```csharp
string fullName = "Ratnakar Kolhatkar";
string msg = $"Name: {fullName}";
```

---

## 3B. Object — The Root of Everything

```csharp
object anyValue1 = 100;
object anyValue2 = "Hello";
```

---

## 3C. Array — Fixed-Size Collection

```csharp
int[] scores = { 85, 90, 78, 95 };
```

---

## 3D. Class

```csharp
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

---

## 3E. Interface

```csharp
public interface IPayable
{
    decimal CalculatePay();
}
```

---

## 3F. Delegate — Reference to a Method

```csharp
delegate int MathOperation(int a, int b);
```

---

# Section 4 — Nullable Types ( value types that can hold null )

```csharp
int? optionalAge = null;
double? optionalScore = null;
```

---

# Section 5 — Collection Types (dynamic-size data structures)

## 5A. List<T> — Dynamic Array ★ MOST USED

```csharp
List<string> cities = new List<string>();
```

---

## 5B. Dictionary<TKey, TValue> — Key-Value Pairs

```csharp
Dictionary<int, string> employeeMap = new();
```

---

## 5C. HashSet<T> — Unique Values Only

```csharp
HashSet<int> uniqueIds = new();
```

---

## 5D. Queue<T> — First In, First Out (FIFO)

```csharp
Queue<string> supportTickets = new();
```

---

## 5E. Stack<T> — Last In, First Out (LIFO)

```csharp
Stack<string> undoHistory = new();
```

---

## 5F. LinkedList<T> — Node-Based List

```csharp
LinkedList<string> taskList = new();
```

---

# Section 6 — Modern C# Types (C# 7, 8, 9, 10, 11+)

## 6A. Tuple — Group Multiple Values Quickly

```csharp
(int Id, string Name) employee = (101, "Ravi");
```

---

## 6B. Record — Immutable Data Model

```csharp
record Product(string Name, decimal Price, int Stock);
```

---

## 6C. Anonymous Type

```csharp
var userInfo = new
{
    Id = 1,
    Name = "Ravi"
};
```

---

## 6D. Span<T> and ReadOnlySpan<T> — High-Performance Slicing

```csharp
Span<int> slice = numbers.AsSpan(1, 3);
```

---

# Section 7 — Boxing and Unboxing

```csharp
int number2 = 42;
object boxed = number2;
int unboxed = (int)boxed;
```

---

# Section 8 — Type Conversion

```csharp
double price2 = 99.99;
int intPrice = (int)price2;
```

```csharp
int parsedAge = int.Parse("28");
bool isValid = int.TryParse("abc", out int result);
```

---

# Section 9 — Pointer Types (Unsafe Code — Rarely Needed)

```csharp
unsafe
{
    int num3 = 10;
    int* ptr = &num3;
}
```

---

# Section 10 — Memory: Stack vs Heap (VISUAL SUMMARY)

```text
STACK                     HEAP
Value Types               Reference Types
Fast                      Garbage Collected
```

---

# Section 11 — Quick Reference Cheat Sheet

| Scenario          | Use This                 |
| ----------------- | ------------------------ |
| Whole numbers     | int                      |
| Money             | decimal                  |
| Text              | string                   |
| Dynamic-size list | List<T>                  |
| Key-value lookup  | Dictionary<TKey, TValue> |
| No duplicates     | HashSet<T>               |
| Immutable model   | record                   |
| Named constants   | enum                     |

---

# Section 12 — Interview Must-Know Points

```text
✔ string is immutable
✔ decimal is best for money
✔ var is compile-time typed
✔ dynamic is runtime typed
✔ List<T> is dynamic, Array is fixed
✔ record uses value equality
✔ TryParse is safer than Parse
✔ Nullable uses '?'
✔ Boxing/unboxing has performance cost
✔ Use Span<T> for high-performance memory work
```
