## Date

"2/26/2018, 5:57:14 PM"
``` javascript
new Date().toLocaleString()  // if you are in the U.S.
```

"2/26/2018, 5:57:14 PM"
``` javascript
new Date().toLocaleString('en-US')  // guaranteed US format
```

"2018-02-27T00:00:38.936Z"
``` javascript
new Date().toISOString()  // UTC Date
```
