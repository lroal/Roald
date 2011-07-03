namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloWorldPresenter = function ()
{
	var _view = Roald.HelloWorld.NewHelloWorldView();
	var _sentence = Roald.HelloWorld.NewWorldSentence();
	
	_view.SetHelloMsg(_sentence.Print());
	
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

