# Toggle Texts
###### Disclaimer: All sample code provided here is for illustrative purposes only and is provided "AS IS" without any warranties of any kind. These examples have not been thoroughly tested under all conditions.

### Collapse extension

|Attribute|Description|
|-----|-----|
|x-toggle-msg-collapse| A message displayed when target is collapsed|
|x-toggle-msg-collapse| A message displayed when target is shown|

JavaScript
``` javascript
$(document).on('click', 'button[data-toggle][data-target][x-toggle-msg-collapse][x-toggle-msg-show]', function () {
    var expanded = $(this).attr('aria-expanded') == 'true';
    var msg = $(this).attr(expanded ? 'x-toggle-msg-show' : 'x-toggle-msg-collapse');
    $(this).text(msg);
})
```
HTML
``` html
<div id="text" class="collapse">
	<!-- SOMETHING LONG -->
</div>
<button type="button" data-toggle="collapse" data-target="#text" x-toggle-msg-collapse="See more" x-toggle-msg-show="Show less">
    See more
</button>
```



**Dependencies:**
- JQuery
