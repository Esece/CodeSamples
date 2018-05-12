## char (C#)


Pointer Arithmetic
``` csharp
string value = "testing";

fixed (char* pValue = value)
{
    char* pV = pValue;
    
    while (*pV != 0)
    {
        Console.Write((char)(*pV++ - 32));
    }
}
```
