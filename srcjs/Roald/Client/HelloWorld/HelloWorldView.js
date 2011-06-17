namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloWorldView = function()
{
	function getHtml()
	{
		return "<p>Hello World </p>";
	}
	
	this.GetHtml = getHtml;
}

Roald.HelloWorld.NewHelloWorldView = function  ()
{
    return new Roald.HelloWorld.HelloWorldView();
}