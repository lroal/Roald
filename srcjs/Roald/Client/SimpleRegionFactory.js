Roald.SimpleRegionFactory = function()
{
	var _elementId;
		
	this.Create = function (elementId)
	{
		var instance = Roald.NewSimpleRegion();
		instance.Setup(elementId);
		return instance;
	}
			
}

