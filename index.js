var edge = require('edge');
var dllPath = require('path').join(__dirname, 'WindowScrape.dll');
console.log(require('path').join(__dirname, 'index.cs'));
var getWindowDetailsByTitle = edge.func({
	source:require('path').join(__dirname, 'index.cs'),
	references:[dllPath,'System.Drawing.dll'],
	methodName:'getWindowDetailsByTitle'
});
var getWindowDetailsByClassName = edge.func({
	source:require('path').join(__dirname, 'index.cs'),
	references:[dllPath,'System.Drawing.dll'],
	methodName:'getWindowDetailsByClassName'
});

var activateWindow = edge.func({
	source:require('path').join(__dirname, 'index.cs'),
	references:[dllPath,'System.Drawing.dll'],
	methodName:'activateWindow'
});

var minimizeWindow = edge.func({
	source:require('path').join(__dirname, 'index.cs'),
	references:[dllPath,'System.Drawing.dll'],
	methodName:'minimizeWindow'
});


module.exports = {
	getWindowDetailsByTitle,
	getWindowDetailsByClassName,
	activateWindow,
	minimizeWindow
};



