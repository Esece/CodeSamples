###### jQuery Validation (plugin)
### 

HTML
``` html
<form action="save.html">
  <input name="name" data-rule-required="true" data-msg-required="Name is required." />
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
  <input name="name" data-rule-required="true" data-msg-required="Name is required." />
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
  }
});
```
