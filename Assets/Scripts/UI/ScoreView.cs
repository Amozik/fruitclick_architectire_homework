using DefaultNamespace.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        private ICollectableViewModel _collectableViewModel;

        public void Initialize(ICollectableViewModel collectableViewModel)
        {
            _collectableViewModel = collectableViewModel;
            _collectableViewModel.OnScoreChange += OnScoreChange;

            OnScoreChange(0);
        }
        
        private void OnScoreChange(int score)
        {
            _text.text = score.ToString();
        }

        ~ScoreView()
        {
            _collectableViewModel.OnScoreChange -= OnScoreChange;
        }
    }
}