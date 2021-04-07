using System;
using Data;
using DefaultNamespace.UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] 
        private GameConfig _gameConfig;
       
        private Camera _mainCamera;

        private void Start()
        {
            _mainCamera = Camera.main;

            var playerModel = new PlayerModel(_gameConfig.livesCount, 0);
            var collectableVM = new AppleViewModel(playerModel);

            new UiInitialization(_gameConfig.uiConfig, collectableVM, _gameConfig.livesCount);
            
            var spawner = new Spawner(collectableVM, _gameConfig.collectablePrefab, _gameConfig.spawnPosition);
            spawner.Spawn();
        }
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
                var hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
                if (hit.collider.TryGetComponent<CollectableView>(out var collectable))
                {
                    collectable.Collect(1);
                }
            }
        }
    }
}