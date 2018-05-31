## ng-src

Does not display a console error
``` html
<img ng-src="{{data.path}}" alt="{{data.altPath}}" />
```

DOES display a console error (Browser trying to access '{{data.path}}' as a URL.
``` html
<img src="{{data.path}}" alt="{{data.altPath}}" />
```
