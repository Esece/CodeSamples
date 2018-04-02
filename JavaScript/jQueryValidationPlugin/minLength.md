## minLength

|Attribute|Value|
|-----|-----|
|data-rule-minLength|[minimum character length]|
|data-msg-minLength|[validation error message]|

``` html
<form name="frm">
  <input type="text" name="UserName" data-rule-minLength="8" data-msg-minLength="User Name must have at least 8 characters." />
  :
</form>
```
``` javascript
$(document.forms['frm']).validate();  // initializing
```
