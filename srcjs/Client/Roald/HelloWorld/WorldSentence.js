namespace("Roald.HelloWorld");

Roald.HelloWorld.WorldSentence = function (context)
{
	var instance = context || {};
	var _hello = Roald.HelloWorld.NewHelloSentence(instance);
	var _helloPrint = _hello.Print;

	var _goodbye = Roald.HelloWorld.NewGoodbyeSentence(instance);
	var _goodbyePrint = _goodbye.Print;
	
	function print() {
		return "World says " + _helloPrint() + " and " + _goodbyePrint();
	}
	
	instance.Print = print;
 	return instance;
}

Roald.HelloWorld.NewWorldSentence = function  (context)
{
    return new Roald.HelloWorld.WorldSentence(context);
}

