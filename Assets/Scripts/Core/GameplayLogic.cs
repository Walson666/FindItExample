using System;
using UnityEngine;
using Zenject;
using Minidev;
using Minidev.Core.SaveLoad;


namespace Minidev.Core
{
    public class GameplayLogic : IInitializable, IDisposable
    {

        private GameplayData _data;

        private SaveLoadService _saveLoadService;

        public event Action<GameplayData> OnGameplayDataLoaded;
        public event Action<GameplayData> OnGameplayDataUpdated;

        public void Initialize()
        {
            Debug.Log("Game Started");
            _data = _saveLoadService.Load();
            OnGameplayDataLoaded?.Invoke(_data);
        }
        public void Dispose()
        {
            Debug.Log("Game Ended");
        }

        public GameplayLogic(SaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }
    }
}
    


