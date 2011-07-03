namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloWorldView = function()
{
	var _helloMsg = undefined;

	function getHtml()
	{
		return "<p>" + _helloMsg + "</p>";
	}

	function setHelloMsg(helloMsg) {
		
		_helloMsg = helloMsg;		
	}
	
	
	this.GetHtml = getHtml;
	this.SetHelloMsg = setHelloMsg;
}

Roald.HelloWorld.NewHelloWorldView = function  ()
{
    return new Roald.HelloWorld.HelloWorldView();
}