﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_Basket
{
    public class ScoreKeeper : IScoreKeeper
    {
        private string scoreKeeper = "000:000";
        private string scoreTeamB = "000";
        private string scoreTeamA = "000";

        public string GetScore()
        {
            return scoreKeeper;
        }

        public void ScoreTeamA1()
        {
            if (scoreKeeper.Equals("000:" + scoreTeamB))
            {
                scoreTeamA = "001";
            }
            else if (scoreKeeper.Equals("001:" + scoreTeamB))
            {
                scoreTeamA = "002";
            }
            else
            {
                scoreTeamA = "003";
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
            throw new NotImplementedException();
        }

        public void ScoreTeamB3()
        {
            throw new NotImplementedException();
        }

        public void ScoreTeamB2()
        {
            throw new NotImplementedException();
        }

        //private static string ConvertScore(int scoreTeam1)
        //{
        //    return scoreTeam1.ToString().Length switch
        //    {
        //        1 => "00" + scoreTeam1.ToString(),
        //        2 => "0" + scoreTeam1.ToString(),
        //        3 => scoreTeam1.ToString(),
        //        _ => throw new NotImplementedException(),
        //    };
        //}

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