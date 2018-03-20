## Simple CSS-Only Accordion
A simple solution without JavaScript

``` css
input[type=checkbox] {
    position: absolute;
    top: -9999px;
    left: -9999px;
}

div.toggle-detail {
    display: none;
}

input[type=checkbox]:checked ~ div.toggle-detail {
    display: block;
    background: green;
    width: 100%;
    padding: 50px;
    color: white;
}
```

``` html
<div>
    <label for="toggle-cb1">HEADER 1</label>
    <input type="checkbox" id="toggle-cb1">
    <div class="toggle-detail">DETAIL 1</div>
</div>
<div>
    <label for="toggle-cb2">HEADER 2</label>
    <input type="checkbox" id="toggle-cb2">
    <div class="toggle-detail">DETAIL 2</div>
</div>
```
