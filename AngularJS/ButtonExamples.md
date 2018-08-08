## Button Examples with AngularJS

Button Activated by Text (1)
``` html
<input type="text" ng-model="name" />
<button type="button" disabled ng-hide="(name || '').trim().length">Save</button>
<button type="submit" ng-show="(name || '').trim().length">Save</button>
```
