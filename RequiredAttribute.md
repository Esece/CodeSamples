###### System.ComponentModel.DataAnnotations.RequiredAttribute
### RequiredAttribute

The error message defined in a different place.
``` csharp
public class LoginModel
{
    [Required(ErrorMessageResourceName = "InvalidUserName", ErrorMessageResourceType = typeof(Messages), ErrorMessage = null)]
    public string UserName { get; set; }
    :
```
``` csharp
public class Messages
{
    public string InvalidUserName { get; set; } = "Username is required";
    :
```
