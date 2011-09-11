using System;

namespace Roald.CompositeDemo.CurrenciesPresenterSpecs.New.Activated
{
    internal abstract class CurrenciesFailed_Act : Activate_Act
    {
        protected const string ErrorMsg = "ErrorMsg";
        protected Exception Exception = new Exception(ErrorMsg);

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            ErrorHandler.Invoke(Exception);
        }

        
    }
}