namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloWorldPresenter = function ()
{
	var _view = Roald.HelloWorld.NewHelloWorldView();
	
	function activate(region)
    {
		region.Add(_view);
    }
	
	this.Activate = activate;
 
}

Roald.HelloWorld.NewHelloWorldPresenter = function  ()
{
    return new Roald.HelloWorld.HelloWorldPresenter();
}

