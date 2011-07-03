namespace("Roald.HelloWorld");

Roald.HelloWorld.GoodbyeSentence = function (context)
{
	var instance = context || {};
	
	function print() {
		return "Goodbye!";
	}
	
	instance.Print = print;
 	return instance;
}

Roald.HelloWorld.NewGoodbyeSentence = function  (context)
{
    return new Roald.HelloWorld.GoodbyeSentence(context);
}

