# .NET / C# Assessment Review

This document summarizes common .NET and C# questions and answers that appeared in the assessment, covering key concepts like LINQ, exception handling, extension methods, and multithreading.

---

## 1. Modifying a List During Iteration

```csharp
var listOfNumbers = new List<int>() { 1, 2, 3, 3, 3, 4 };
foreach (var num in listOfNumbers)
{
    if (num == 3)
        listOfNumbers.Remove(num);
}
```

**Result:**
```
InvalidOperationException: Collection was modified; enumeration operation may not execute.
```

You cannot modify a collection while iterating through it. Use one of these instead:
```csharp
listOfNumbers.RemoveAll(n => n == 3);
// or
listOfNumbers = listOfNumbers.Where(n => n != 3).ToList();
```

---

## 2. String Extension to Check If String Is a Number

```csharp
public static class StringExtensions
{
    public static bool IsNumber(this string value)
    {
        return double.TryParse(value, out _);
    }
}
```

**Usage:**
```csharp
Console.WriteLine("123.45".IsNumber()); // True
Console.WriteLine("abc".IsNumber());   // False
```

---

## 3. Ensure Code Executes Regardless of Exceptions

```csharp
try
{
    Connect();
}
catch
{
    // handle or ignore error
}
finally
{
    UpdateStatistics();
}
```

✅ `finally` always executes, even when exceptions are thrown.

---

## 4. LINQ Sorting from Largest to Smallest

```csharp
var numbers = new List<int>() { 8, 4, 5, 6, 7 };
var sortedList = numbers.OrderByDescending(o => o).ToList();
```

**Output:**
```
8, 7, 6, 5, 4
```

---

## 5. String Interpolation Example

```csharp
int a = 1;
int b = 2;
Console.WriteLine($"a={a}, b={b}");
```

**Output:**
```
a=1, b=2
```

---

## 6. ThreadLocal Example

```csharp
private static ThreadLocal<int> Counter = new ThreadLocal<int>();

private static void Increment()
{
    for (int i = 0; i < 100; i++)
        Counter.Value++;
    Console.WriteLine($"The counter after Increment is {Counter}.");
}

private static void DecrementByTwo()
{
    for (int i = 0; i < 100; i++)
        Counter.Value -= 2;
    Console.WriteLine($"The counter after DecrementByTwo is {Counter}.");
}

static void Main()
{
    var firstThread = new Thread(Increment);
    firstThread.Start();
    firstThread.Join();

    var secondThread = new Thread(DecrementByTwo);
    secondThread.Start();
    secondThread.Join();

    Console.WriteLine($"The counter is {Counter}");
}
```

**Output:**
```
The counter after Increment is 100.
The counter after DecrementByTwo is -200.
The counter is 0
```

Each thread gets its own local copy of the variable `Counter.Value`.

---

## Summary Table

| Concept | Key Idea | Example |
|----------|-----------|----------|
| **Collection modification** | Cannot modify while iterating | `InvalidOperationException` |
| **Extension method** | Add behavior to `string` | `IsNumber()` |
| **Exception handling** | Use `finally` for guaranteed execution | `try/catch/finally` |
| **LINQ sorting** | `OrderByDescending` | Sort descending |
| **String interpolation** | `$"a={a}"` | Outputs variable values |
| **ThreadLocal** | Each thread gets its own copy | Separate values per thread |

---

**Author:** Jandre Janse van Vuuren  
**Language:** C# (.NET)

