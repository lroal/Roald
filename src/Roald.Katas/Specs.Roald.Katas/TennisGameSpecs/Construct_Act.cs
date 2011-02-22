using System;

namespace Roald.Katas.TennisGameSpecs
{
    internal class Construct_Act
    {

        protected virtual void Arrange()
        {
        }

        protected virtual void Act()
        {
            Game = new TennisGame();
        }

        protected TennisGame Game { get; set; }
    }
}