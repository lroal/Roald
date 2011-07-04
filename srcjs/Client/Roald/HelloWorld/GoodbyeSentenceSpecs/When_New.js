namespace("Roald.HelloWorld.GoodbyeSentenceSpecs");


TestCase("When new", {
	setUp: function () {
	this.goodbyeSentence = new Roald.HelloWorld.GoodbyeSentence();
	},

	"test print should return": function () {
		assert("should",this.goodbyeSentence.Print() === 'Goodbye!');
	}
});