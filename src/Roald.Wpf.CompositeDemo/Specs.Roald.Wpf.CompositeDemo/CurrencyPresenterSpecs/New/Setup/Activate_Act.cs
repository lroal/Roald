using System;
using Rhino.Mocks;

namespace Roald.CompositeDemo.CurrencyPresenterSpecs.New.Setup
{
    internal abstract class Activate_Act : Setup_Act
    {
        protected IGridLineRegion LineRegion = MockRepository.GenerateStub<IGridLineRegion>();
        protected ICellRegion Cell1 = MockRepository.GenerateStub<ICellRegion>();
        protected ICellRegion Cell2 = MockRepository.GenerateStub<ICellRegion>();
        protected ICellRegion Cell3 = MockRepository.GenerateStub<ICellRegion>();
        protected string Code = "USD";
        protected decimal Value = 7.23m;
        protected string Description = "US Dollars";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCurrency();
            StubLineRegion();
        }

        private void StubCurrency()
        {
            Currency.Stub(x => x.Code).Return(Code);
            Currency.Stub(x => x.Value).Return(Value);
            Currency.Stub(x => x.Description).Return(Description);
        }


        private void StubLineRegion()
        {
            LineRegion.Stub(x => x.CreateCell()).Return(Cell1).Repeat.Once();
            LineRegion.Stub(x => x.CreateCell()).Return(Cell2).Repeat.Once();
            LineRegion.Stub(x => x.CreateCell()).Return(Cell3).Repeat.Once();
        }


        protected override void Act()
        {
            Presenter.Activate(LineRegion);
        }

        
    }
}