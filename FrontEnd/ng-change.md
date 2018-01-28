###### AngularJS
### ng-change

Trigger 'onchange' Event
``` html
<select ng-model="op" ng-change="updateData()">
  <option value="eq">Equal</option>
  <option value="gt">Greater Than</option>
  <option value="lt">Less Than</option>
</select>
```
``` javascript
$scope.updateData = function() {
  :
};
```
