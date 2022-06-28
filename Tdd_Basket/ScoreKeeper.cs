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
        private int scoreTeam_A = 0, scoreTeam_B = 0;

        public string GetScore()
        {
            return scoreKeeper;
        }

        public void ScoreTeamA1()
        {
            scoreTeam_A++;
            UpdateScoreA(scoreTeam_A);
        }

        public void ScoreTeamA2()
        {
            scoreTeam_A += 2;
            UpdateScoreA(scoreTeam_A);
        }

        public void ScoreTeamA3()
        {
            scoreTeam_A += 3;
            UpdateScoreA(scoreTeam_A);
        }

        public void ScoreTeamB1()
        {
            scoreTeam_B++;
            UpdateScoreB(scoreTeam_B);           
        }       

        public void ScoreTeamB2()
        {
            scoreTeam_B += 2;
            UpdateScoreB(scoreTeam_B);
        }

        public void ScoreTeamB3()
        {
            scoreTeam_B += 3;
            UpdateScoreB(scoreTeam_B);
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

        private void UpdateScoreA(int scoreTeam_A)
        {
            scoreTeamA = ConvertScore(scoreTeam_A);
            scoreKeeper = scoreTeamA + ":" + scoreTeamB;
        }

        private void UpdateScoreB(int scoreTeam_B)
        {
            scoreTeamB = ConvertScore(scoreTeam_B);
            scoreKeeper = scoreTeamA + ":" + scoreTeamB;
        }
    }
}
