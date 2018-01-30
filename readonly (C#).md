###### C#
### readonly Keyword

Null Object Pattern
``` csharp
class Contact
{
    public static readonly Empty = new Contact();
    :
    private Contact() { }
}
```
> Also makes referencial comparison valid for equality checking

