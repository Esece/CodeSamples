## Convert NodeList to Array

``` javascript
Array.prototype.slice.call(document.querySelectorAll('div')).map(function (e) { console.log(e); });
```
