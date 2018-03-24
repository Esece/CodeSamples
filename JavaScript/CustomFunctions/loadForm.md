## loadForm

Takes parent element (usually form) and data (query string or object) and populates the child elements by name
``` javascript
function loadForm(form, data) {
    // can optimize by removing duplicate code
    if (typeof data === 'string' || data instanceof String) {
        var kvs = data.split('&');
        for (var i = 0; i < kvs.length; i++) {
            var pair = kvs[i].split('=');
            var name = decodeURIComponent(pair[0]);
            var val = decodeURIComponent(pair[1]);
            var element = form.querySelector('[name="' + name + '"]');
            if (element) {
                element.value = val;
            }
        }
    }
    else {
        var keys = [];
        for (var key in data) {
            if (data.hasOwnProperty(key)) keys.push(key);
        }
        for (var i = 0; i < keys.length; i++) {
            var name = keys[i];
            var val = data[keys[i]];
            var element = form.querySelector('[name="' + name + '"]');
            if (element) {
                element.value = val;
            }
        }
    }
}
```
