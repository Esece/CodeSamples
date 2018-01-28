###### jQuery Validation (plugin)
### 

HTML
``` html
<form action="save.html">
  <input type="text" name="name" data-rule-required="true" data-msg-required="Name is required." />
  <button>Save</button>
</form>
```

Script
``` javascript
$('form').validate();
```

> Error messages will be added by the plugin including markup
``` html
<lable id="Name-error" for="name">Name is required.</label>
```

Apply Custom Style to Error Message
``` javascript
$('form').validate({
  errorClass: 'text-danger'  // red text in bootstrap
});
```

Specify Custom Error Message Location
HTML
``` html
<form action="save.html">
  <span class="errmsg"></span>
  <input type="text" name="name" data-rule-required="true" data-msg-required="Name is required." />
  <button>Save</button>
</form>
```
``` javascript
$('form').validate({
  errorLabelContainer: '.errmsg'  // selector
});
```

Use Custom Submit Handler
``` javascript
$('form').validate({
  submitHandler: function (form) {
    console.log('submitted');
    return true;
  }
});
```

Conditionally Validate
HTML
``` html
<form action="save.html">
  <span class="errmsg"></span>
  <input type="checkbox" name="validate" />
  <input type="text" name="name" data-rule-required="[name='validate']:checked" data-msg-required="Name is required." />
  <button>Save</button>
</form>
```
``` javascript
$('form').validate({
  submitHandler: function (form) {
    console.log('validate checked and submitted');
    return true;
  }
});
```
