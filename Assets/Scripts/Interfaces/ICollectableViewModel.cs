using System;

namespace DefaultNamespace.Interfaces
{
    public interface ICollectableViewModel
    {
        event Action<int> OnScoreChange;
        event Action<int> OnLivesChange;

        void AddScore(int value);
        void SubtractLive();
    }
}