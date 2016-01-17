#Windoze

Query windows, in windows.

Windoze allows windows node applications to query and modify windows in windows. It is an [edge](https://github.com/tjanczuk/edge) module and 
uses a [fork](https://github.com/ProbablePrime/WindowScrape) of the [WindowScrape](https://github.com/DataDink/WindowScrape) C# library.

#Example

##Getting the currently playing song in Spotify

```
var windoze = require('windoze');

window = windoze.getWindowDetailsByClassName('SpotifyMainWindow',true);
console.log(window);
```

Result:
```
{
  x: 0,
  y: 100,
  height: 760,
  width: 1440,
  title: 'Queen - Bohemian Rhapsody - 2011 Remaster',
}
```

#TODO

* Identify what this modules .Net requirements are and add them in the Readme
* Publish to npm?
