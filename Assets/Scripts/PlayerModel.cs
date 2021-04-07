using DefaultNamespace.Interfaces;

namespace DefaultNamespace
{
    public class PlayerModel : IPlayerModel
    {
        public int Lives { get; set; }
        public int Score { get; set; }

        public PlayerModel(int lives, int score)
        {
            Lives = lives;
            Score = score;
        }
    }
}