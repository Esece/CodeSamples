## required

|Attribute|Value|
|-----|-----|
|data-rule-required|true|
|data-msg-required|[validation error message]|

``` html
<form id="frm">
  <input type="text" name="UserName" data-rule-required="true" data-msg-required="User Name is Required." />
  :
</form>
```
``` javascript
$('#frm').validate();  // initializing
```
