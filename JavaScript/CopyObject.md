## Copy Object

``` javascript
var src = { test: 123 };
var dest = {};

for (var prop in src) {
  dest[prop] = src[prop];
}

console.log(dest);  // { test: 123 }
```
