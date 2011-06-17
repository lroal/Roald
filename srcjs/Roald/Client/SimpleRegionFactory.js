namespace("Roald");

Roald.SimpleRegionFactory = function()
{
	var _elementId;
		
	function create(elementId)
	{
		var instance = Roald.NewSimpleRegion();
		instance.Setup(elementId);
		return instance;
	}
	
	this.Create = create;
			
}

Roald.NewSimpleRegionFactory = function  ()
{
    return new Roald.SimpleRegionFactory();
}

