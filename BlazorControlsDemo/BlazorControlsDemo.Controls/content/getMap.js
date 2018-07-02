// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

var loadJS = function (url, implementationCode, location) {
  //url is URL of external file, implementationCode is the code
  //to be called from the file, location is the location to 
  //insert the <script> element

  var scriptTag = document.createElement('script');
  scriptTag.src = url;

  scriptTag.onload = implementationCode;
  // scriptTag.onreadystatechange = implementationCode;

  location.appendChild(scriptTag);
};

var yourCodeToBeCalled = function () {
  //your code goes here
  console.log('### Script loaded ###');
  Blazor.registerFunction('BlazorControlsDemo.Controls.getMap', function (id, key) {
    console.log('### Called getMap###')
    var map = new Microsoft.Maps.Map('#' + id, {
      credentials: key
    });
    return "OK";
  });
}

loadJS('http://www.bing.com/api/maps/mapcontrol', yourCodeToBeCalled, document.body);

