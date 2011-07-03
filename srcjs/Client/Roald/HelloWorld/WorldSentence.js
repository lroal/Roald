namespace("Roald.HelloWorld");

Roald.HelloWorld.WorldSentence = function (context)
{
	
	var instance = context || {};
	var _hello = undefined;
	var _helloPrint = undefined;
	var _goodbye = undefined;
	var _goodbyePrint = undefined;

	resolveHelloSentence();
	resolveGoodbyeSentence();
	setupInstance();
	return instance;

	function resolveHelloSentence() {
		_hello = Roald.HelloWorld.NewHelloSentence(instance);
		_helloPrint = _hello.Print;
	}

	function resolveGoodbyeSentence() {
		_goodbye = Roald.HelloWorld.NewGoodbyeSentence(instance);
		_goodbyePrint = _goodbye.Print;
	}

	function setupInstance() {
		instance.Print = print;
 	}

	
	function print() {
		return "World says " + _helloPrint() + " and " + _goodbyePrint();
	}
	
}

Roald.HelloWorld.NewWorldSentence = function  (context)
{
    return new Roald.HelloWorld.WorldSentence(context);
}

