using System.Threading.Tasks;
using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace
{
    public class Spawner
    {
        private readonly ICollectableViewModel _collectableViewModel;
        private readonly GameObject _collectablePrefab;
        private readonly Vector2 _spawnPosition;

        public Spawner(ICollectableViewModel collectableViewModel, GameObject collectablePrefab, Vector2 spawnPosition)
        {
            _collectableViewModel = collectableViewModel;
            _collectablePrefab = collectablePrefab;
            _spawnPosition = spawnPosition;
        }

        public void Spawn()
        {
            var view = Object.Instantiate(_collectablePrefab, _spawnPosition, Quaternion.identity).GetComponent<AppleView>();
            view.Initialize(_collectableViewModel);
        }
        
    }
}