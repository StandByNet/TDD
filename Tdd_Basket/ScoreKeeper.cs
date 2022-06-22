using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_Basket
{
    public class ScoreKeeper : IScoreKeeper
    {
        private string scoreBorad = "", scoreTeamA = "", scoreTeamB = "", buttonPut;
        private int scoreTeam1 = 0, scoreTeam2 = 0;

        public string GetScore()
        {
            ScoreTeamA1();
            ScoreTeamA2();
            return scoreBorad;
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

        public void ScoreTeamA1()
        {
            if (scoreBorad.Equals(scoreTeamA + ":" + scoreTeamB))
            {
                scoreTeam1++;
                scoreTeamA = ConvertScore(scoreTeam1);
                scoreBorad = scoreTeamA + ":" + scoreTeamB;
            }
            InitalizScore();
        }

        private void InitalizScore()
        {
            if (String.IsNullOrEmpty(scoreBorad))
            {
                scoreTeamA = "000";
                scoreTeamB = "000";
                scoreBorad = scoreTeamA + ":" + scoreTeamB;
            }
        }

        public void ScoreTeamA2()
        {
            if (scoreBorad.Equals(scoreTeamA + ":" + scoreTeamB))
            {
                scoreTeam2++;
                scoreTeamB = ConvertScore(scoreTeam2);
                scoreBorad = scoreTeamA + ":" + scoreTeamB;
            }
            InitalizScore();
        }

        public void ScoreTeamA3()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamB1()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamB2()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamB3()
        {
            throw new NotImplementedException();
        }
    }
}
