using NUnit.Framework;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterSpecs.New.Setup
{
    [TestFixture]
    internal class When_Activating : Activate_Act
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        [Test]
        public void It_Should_Add_CodeView_To_Cell1()
        {
            Cell1.AssertWasCalled(x => x.Add(CodeView));
        }

        [Test]
        public void It_Should_Add_ValueView_To_Cell2()
        {
            Cell2.AssertWasCalled(x => x.Add(ValueView));
        }

        [Test]
        public void It_Should_Add_DescriptionView_To_Cell3()
        {
            Cell3.AssertWasCalled(x => x.Add(DescriptionView));
        }

        [Test]
        public void It_Should_Set_Code_In_CodeView()
        {
            CodeView.AssertWasCalled(x => x.SetCode(Code));
        }

        [Test]
        public void It_Should_Set_Value_In_ValueView()
        {
            ValueView.AssertWasCalled(x => x.SetValue(Value));
        }

        [Test]
        public void It_Should_Set_Description_In_DescriptionView()
        {
            DescriptionView.AssertWasCalled(x => x.SetDescription(Description));
        }


    }
}