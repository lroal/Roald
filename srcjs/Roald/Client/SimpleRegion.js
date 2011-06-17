Roald.SimpleRegion = function()
{
	var _elementId;
		
	this.Setup = function (elementId)
	{
		this._elementId = elementId;					
		this.changeId();
	}
	
	this.changeId = function ()
	{
		var newId = "newId";
		$("#"+this._elementId).attr("id", newId);
		this._elementId = newId;
	}
	
	this.Add = function (view)
	{
		$("#" + this._elementId).html(view.GetHtml());
	}
		
}

