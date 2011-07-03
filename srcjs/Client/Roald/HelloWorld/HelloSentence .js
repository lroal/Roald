namespace("Roald.HelloWorld");

Roald.HelloWorld.HelloSentence = function (context)
{
	var instance = context || {};
	
	function print() {
		return "Hello!";
	}
	
	instance.Print = print;
 	return instance;
}

Roald.HelloWorld.NewHelloSentence = function  (context)
{
    return new Roald.HelloWorld.HelloSentence(context);
}

