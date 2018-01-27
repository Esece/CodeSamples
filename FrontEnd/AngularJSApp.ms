###### AngularJS

HTML
``` html
<div ng-app="app" ng-controller="ctrl">
</div>
```

Script
``` javascript
var app = angular.module('app', []);
var controller = app.controller('ctrl', ['$scope', '$http', function ($scope, $http) {
}]);
```
