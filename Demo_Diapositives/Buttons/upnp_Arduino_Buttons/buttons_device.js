
function createServerPlusDevice(upnp, server, device) {
	var peer = upnp.createPeer({
    prefix: "/upnp",
    server: server
}).on("ready",function(peer){
    console.log("ready");
    // advertise device after peer is ready
    device.advertise();
}).on("close",function(peer){
    console.log("closed");
}).start();


var device = peer.createDevice({
	    autoAdvertise: false,
	    uuid: "6bd5eabd-b7c8-4f7b-ae6c-a30ccdeb5988",
	    productName: "potentiometer",
	    productVersion: "0.0.1",
	    domain: "schemas-upnp-org",  	//Error when domain changed
	    type: "upnp_potentiometer",
	    version: "1",
	    friendlyName: "BUTTONS",
	    manufacturer: "IRIT",
	    modelName: "buttons",
	    modelDescription: "boutons upnp sur arduino",
	    modelNumber: "0.0.1",
	    modelURL: "http://www.famium.org",
	    serialNumber: "1234-1234-1234-1234",
	    UPC: "123456789012"
	});
	return device;
}
