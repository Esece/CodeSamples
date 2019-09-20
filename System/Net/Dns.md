##### System.Net.Dns
## Dns

Get Local IP Address
``` csharp
static string GetLocalIPAddress()
{
    foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
    {
        if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
            return ip.ToString();
        }
    }

    return null;
}
```
