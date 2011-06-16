function namespace(theNamespace) {
	var root = window;
	var parts = theNamespace.split(".");
	
	for(var i = 0; i < parts.length; i++) {
		if( root[ parts[i] ] == undefined ) {
			root[ parts[i] ] = new Object;
		}
		
		root = root[ parts[i] ];
	}
}