## MethodBody

Get Local variables
``` charp
 var current = new System.Diagnostics.StackTrace().GetFrame(0);
 current.GetMethod().GetMethodBody().LocalVariables
```
