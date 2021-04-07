using DefaultNamespace.UI;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "UiConfig", menuName = "Configs/UiConfig", order = 0)]
    public class UiConfig : ScriptableObject
    {
        public ScoreView score;
        public LivesView lives;
        public GameObject endGame;
    }
}