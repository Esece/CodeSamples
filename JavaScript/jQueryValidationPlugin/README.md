https://jqueryvalidation.org/

## jQuery Validation Plugin

One of the easiest-to-use, the most flexible validation framework built on top of jQuery.
For complete documentation, refer to https://jqueryvalidation.org/.

**Recommended Implementation**

``` html
<form id="frm">
  <input type="text" name="UserName" data-rule-required="true" data-msg-required="User Name is Required." />
  :
</form>
```

``` javascript
$(function() {
  $('#frm').validate();  // initializing
})
```

|Attribute|Value|
|-----|-----|
|data-rule-required|true|
|data-msg-required|[validation error message]|



