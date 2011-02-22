
namespace Roald.Katas
{
    public class TennisGame
    {
        private int _wins1;
        private int _wins2;

        public string Score
        {
            get
            {
                if (HasAWinner)
                {
                    return EncodeWinnerScore();
                }
                if (IsEqualScore)
                {
                    return EncodeEqualScore();
                }
                if (HasAdvantage)
                {
                    return EncodeAdvantageScore();
                }
                return EncodeSimpleScores();
            }
        }

        private bool HasAWinner
        {
            get { return PlayerOneWon || PlayerTwoWon; }
        }

        private bool PlayerOneWon
        {
            get { return PlayerOneAtLeastFourWins && PlayerOneAheadWithTwoWins; }
        }

        private bool PlayerOneAtLeastThreeWins
        {
            get { return _wins1 > 2; }
        }


        private bool PlayerOneAtLeastFourWins
        {
            get { return _wins1 > 3; }
        }

        private bool PlayerOneAheadWithTwoWins
        {
            get { return _wins1 - _wins2 == 2; }
        }

        private bool PlayerTwoWon
        {
            get { return PlayerTwoAtLeastFourWins && PlayerTwoAheadWithTwoWins; }
        }

        private bool PlayerTwoAtLeastThreeWins
        {
            get { return _wins2 > 2; }
        }

        private bool PlayerTwoAtLeastFourWins
        {
            get { return _wins2 > 3; }
        }

        private bool PlayerTwoAheadWithTwoWins
        {
            get { return _wins2 - _wins1 == 2; }
        }

        private string EncodeWinnerScore()
        {
            return PlayerOneWon ? "player one wins" : "player two wins";
        }

        private bool IsEqualScore
        {
            get { return _wins1 == _wins2; }
        }

        private string EncodeEqualScore()
        {
            if (IsDeuce)
            {
                return "deuce";
            }                     
            return EncodeSimpleScore1() + " all";            
        }

        private bool IsDeuce
        {
            get { return PlayerOneAtLeastThreeWins && PlayerTwoAtLeastThreeWins && HaveEqualWins; }
        }
              
        private bool HasAdvantage
        {
            get { return PlayerOneHasAdvantage || PlayerTwoHasAdvantage; }
        }

        private bool PlayerOneHasAdvantage
        {
            get { return PlayerOneAtLeastFourWins && !HaveEqualWins; }
        }

        private bool PlayerTwoHasAdvantage
        {
            get { return PlayerTwoAtLeastFourWins && !HaveEqualWins; }
        }

        private bool HaveEqualWins
        {
            get
            {
                return _wins1 == _wins2;
            }            
        }
      
        private string EncodeAdvantageScore()
        {
            if (_wins1 > _wins2)
            {
                return  "advantage to player one";                
            }
            return "advantage to player two";                
        }

        private string EncodeSimpleScores()
        {
            return EncodeSimpleScore1() + " " + EncodeSimpleScore2();
        }

        private string EncodeSimpleScore1()
        {
            return  GetSimpleScore(_wins1);                        
        }

        private string EncodeSimpleScore2()
        {
            return GetSimpleScore(_wins2);
        }

        private static string GetSimpleScore(int wins)
        {
            switch (wins)
            {
                case 0:
                    return "love";
                case 1:
                     return "fifteen";
                case 2:
                    return "thirty";
                case 3:
                    return "fourty";
                default:
                    return "love";
            }
        }
      
        public void PlayerOneWinBall()
        {
            _wins1++;
        }

        public void PlayerTwoWinBall()
        {
            _wins2++;
        }
    }
}