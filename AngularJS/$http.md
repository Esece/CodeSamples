## $http

``` javascript
$http({
  method: 'POST', 
  url: 'https://www.me.com/login', 
  headers: {'Authorization': 'xxxyyyzzz'}
});
```

``` javascript
$http.post('https://www.me.com/login', 
  {
    headers: {'Authorization': 'xxxyyyzzz'}
  }
);
```
