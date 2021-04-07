using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig", order = 0)]
    public class GameConfig : ScriptableObject
    {
        public GameObject collectablePrefab;
        public int livesCount = 3;
        public Vector2 spawnPosition = new Vector2(0, 5);
        public UiConfig uiConfig;
    }
}