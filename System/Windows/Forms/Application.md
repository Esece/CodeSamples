###### System.Windows.Forms.Application
## Application

Check GUI or Console while Terminating the Application
``` csharp
Application.MessageLoop ? Application.Exit() : System.Environment.Exit(1);
```
