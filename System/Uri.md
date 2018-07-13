###### System.Uri
### Uri

Modify Path (with the Same Domain)
``` csharp
new Uri(new Uri("https://www.yahoo.com/finance/quotes"), "/mail/inbox").ToString()  // "https://www.yahoo.com/mail/inbox"
```

Host Name
``` csharp
new Uri("https://m.crateandbarrel.com/Checkout/DeliveryAndGiftOptions/").Host  // "m.crateandbarrel.com"
```
