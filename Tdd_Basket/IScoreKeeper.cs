namespace Tdd_Basket
{
    public interface IScoreKeeper
    {
        void ScoreTeamA1();
        void ScoreTeamA2();
        void ScoreTeamA3();
        void ScoreTeamB1();
        void ScoreTeamB2();
        void ScoreTeamB3();
        string GetScore();
    }
}