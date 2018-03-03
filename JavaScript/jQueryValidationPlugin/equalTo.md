## equalTo

|Attribute|Value|
|-----|-----|
|data-rule-equalTo|[selector for the value to compared to]|
|data-msg-equalTo|[validation error message]|

``` html
<form id="frm">
  <input id="pw" type="password" name="Password" />
  <input type="password" data-rule-equalTo="#pw" data-msg-equalTo="Passwords entered do not match!" />
  :
</form>
```
``` javascript
$('#frm').validate();  // initializing
```
