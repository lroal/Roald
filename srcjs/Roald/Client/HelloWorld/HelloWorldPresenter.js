

namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloWorldPresenter = function ()
{
	this._view = Roald.HelloWorld.NewHelloWorldView();
	
	this.Activate = function (region)
    {
		region.Add(this._view);
    }

 
}
