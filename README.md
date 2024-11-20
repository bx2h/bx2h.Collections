# bx2h.Collections

A collection of useful extensions to Unity native collections

## Installation

From Unity Package Manager - Install package from git URL: `https://github.com/bx2h/bx2h.Collections.git`

## NativeArrayExtensions

NativeArrayExtensions.Reverse - reverses the native array in place.

```csharp
NativeArray<int> array = new NativeArray<int>(new int[] { 1, 2, 3, 4, 5 }, Allocator.Temp);
array.Reverse();
Debug.Log(array.ToArray()); // prints [5, 4, 3, 2, 1]
```
