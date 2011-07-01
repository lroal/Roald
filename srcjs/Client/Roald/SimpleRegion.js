namespace("Roald");

Roald.SimpleRegion = function()
{
	var _elementId;
		
	function setup(elementId)
	{
		_elementId = elementId;					
		changeId();
	}
	
	function changeId()
	{
		//todo: use Guid generator
		var newId = "newId";
		$("#"+_elementId).attr("id", newId);
		_elementId = newId;
	}
	
	function add(view)
	{
		$("#" + _elementId).html(view.GetHtml());
	}
	
	this.Setup = setup;
	this.Add = add;
		
}

Roald.NewSimpleRegion = function  ()
{
    return new Roald.SimpleRegion();
}


