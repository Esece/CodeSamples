###### Custom Jquery Validation Method
## remoteserver

``` javascript
$.validator.addMethod('serverside', function (value, element) {
    var validator = this;
    var previous = validator.previousValue(element);

    if (previous.old === value) {
        return previous.valid;
    }

    previous.old = value;
    validator.startRequest(element);

    $.ajax({
        url: element.getAttribute('data-url-serverside'),
        type: 'POST',
        data: {
            value: value
        },
        success: function (response) {
            console.log(this);

            if (response === true || (response !== false && !response)) {
                validator.prepareElement(element);
                validator.formSubmitted = validator.formSubmitted;
                validator.successList.push(element);
                delete validator.invalid[element.name];
                validator.showErrors();
                previous.valid = true;
                validator.stopRequest(element, true);
            }
            else {
                var errors = {};
                var $element = $(element);

                if (!element.getAttribute('data-msg-serverside')) {
                    element.setAttribute('data-msg-serverside', 'The value entered is invalid.');
                }

                var msg = (false === response ? validator.defaultMessage(element, 'serverside') : response);

                element.setAttribute('data-msg-serverside', msg);

                errors[element.name] = msg;
                validator.invalid[element.name] = true;
                validator.showErrors(errors);
                previous.valid = false;
                validator.stopRequest(element, false);
            }
        }
    });
    return true;
});
````

``` html
<input type="text" name="UserName" data-rule-serverside="true" data-url-serverside="/IsUserNameAvailable"/>
```

Server-Side Method Example (MVC)
``` csharp
public ActionResult IsUserNameAvailable(string value)
{
    bool available;
    
    // implementation here 

    return Json(available ? (object)true : "The username entered is already taken.");
}
```
