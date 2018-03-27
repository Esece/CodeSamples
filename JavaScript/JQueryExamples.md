## JQuery Examples

Add a new Button
``` javascript
var newButton = $('<input type="button" value="new button"/>'); 
$("body").append(r);
```

Make an AJAX Call
``` javascript
$.ajax({
    url: '/',
    data: {
        key: value
    },
    success: function (data, textStatus, jqXHR) {
    },
    error: function (jqXHR, textStatus, errorThrown) {
    },
    complete: function (jqXHR, textStatus) {
    }
});
```
