var five = require("johnny-five"),
	board, buttonA, buttonB;
var board = new five.Board({port: 'COM5'});

var upnp = require("peer-upnp");
var http = require("http");
var server = http.createServer();
var PORT = 8080;

var fs = require("fs");
var vm = require("vm");

vm.runInThisContext(fs.readFileSync(__dirname + "/service.js"));
vm.runInThisContext(fs.readFileSync(__dirname + "/buttons_device.js"));


// start server on port 8080. please do this step before you create a peer
server.listen(PORT);


// Create a UPnP Peer.

var device = createServerPlusDevice(upnp, server, device);


var service = createService(device);

var oldValue = 0;
var newValue = 0;
var timeOut = true;



// When the board is ready
board.on("ready", function() {
 // Create a new `button` hardware instance.
  buttonA = new five.Button(2);
  buttonB = new five.Button(3);

  // Inject the `sensor` hardware into
  // the Repl instance's context;
  // allows direct command line access
  board.repl.inject({
    buttonA: buttonA,
	buttonB: buttonB
  });
  
  // Button Event API

  // "down" the button is pressed
  buttonA.on("down", function() {
    console.log("down gauche");
	service.set("Status","GAUCHE");
	service.set("Target","GAUCHE");
	service.notify("Status");
  });

  // "hold" the button is pressed for specified time.
  //        defaults to 500ms (1/2 second)
  //        set
  buttonA.on("hold", function() {
    console.log("hold");
  });

  // "up" the button is released
  buttonA.on("up", function() {
    console.log("up gauche");
	service.set("Status","AUCUN");
	service.set("Target","AUCUN");
	service.notify("Status");
  });
  
  // Button Event API

  // "down" the button is pressed
  buttonB.on("down", function() {
    console.log("down droite");
	service.set("Status","DROITE");
	service.set("Target","DROITE");
	service.notify("Status");
  });

  // "hold" the button is pressed for specified time.
  //        defaults to 500ms (1/2 second)
  //        set
  buttonB.on("hold", function() {
    console.log("hold");
  });

  // "up" the button is released
  buttonB.on("up", function() {
    console.log("up droite");
	service.set("Status","AUCUN");
	service.set("Target","AUCUN");
	service.notify("Status");
  });

 
});
