using System;
using DefaultNamespace.Interfaces;

namespace DefaultNamespace
{
    public class AppleViewModel : ICollectableViewModel
    {
        private readonly IPlayerModel _playerModel;

        public event Action<int> OnScoreChange;
        public event Action<int> OnLivesChange;
        
        public AppleViewModel(IPlayerModel playerModel)
        {
            _playerModel = playerModel;
        }

        public void AddScore(int value)
        {
            _playerModel.Score += value;
            OnScoreChange?.Invoke(_playerModel.Score);
        }

        public void SubtractLive()
        {
            _playerModel.Lives--;
            OnLivesChange?.Invoke(_playerModel.Lives);
        }
    }
}