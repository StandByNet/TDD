using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_Basket
{
    public class ScoreKeeper : IScoreKeeper
    {
        private string scoreKeeper = "000:000", scoreTeamB = "000", scoreTeamA = "000";
        private int scoreTeam_A = 0;

        public string GetScore()
        {
            return scoreKeeper;
        }

        public void ScoreTeamA1()
        {
            if (scoreKeeper.Equals(scoreTeamA + ":" + scoreTeamB))
            {
                scoreTeam_A++;
                scoreTeamA = ConvertScore(scoreTeam_A);
            }
            scoreKeeper = scoreTeamA + ":" + scoreTeamB;
        }

        public void ScoreTeamA2()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamA3()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamB1()
        {
            if (scoreKeeper.Equals(scoreTeamA + ":" + scoreTeamB))
            {
                scoreKeeper = "000:001";
            }
        }

        public void ScoreTeamB3()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamB2()
        {
            throw new NotImplementedException();
        }

        private static string ConvertScore(int scoreTeam1)
        {
            return scoreTeam1.ToString().Length switch
            {
                1 => "00" + scoreTeam1.ToString(),
                2 => "0" + scoreTeam1.ToString(),
                3 => scoreTeam1.ToString(),
                _ => throw new NotImplementedException(),
            };
        }

        ////public void ScoreTeamA1()
        ////{
        ////    if (scoreBorad.Equals(scoreTeamA + ":" + scoreTeamB))
        ////    {
        ////        scoreTeam1++;
        ////        scoreTeamA = ConvertScore(scoreTeam1);
        ////        scoreBorad = scoreTeamA + ":" + scoreTeamB;
        ////    }
        ////    InitalizScore();
        ////}

        //private void InitalizScore()
        //{
        //    if (String.IsNullOrEmpty(scoreBorad))
        //    {
        //        scoreTeamA = "000";
        //        scoreTeamB = "000";
        //        scoreBorad = scoreTeamA + ":" + scoreTeamB;
        //    }
        //}

    }
}
