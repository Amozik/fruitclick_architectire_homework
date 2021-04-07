using DefaultNamespace.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    public class LivesView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        private ICollectableViewModel _collectableViewModel;

        public void Initialize(ICollectableViewModel collectableViewModel, int livesCount)
        {
            _collectableViewModel = collectableViewModel;
            _collectableViewModel.OnLivesChange += OnLivesChange;

            OnLivesChange(livesCount);
        }
        
        private void OnLivesChange(int score)
        {
            _text.text = score.ToString();
        }

        ~LivesView()
        {
            _collectableViewModel.OnScoreChange -= OnLivesChange;
        }
    }
}