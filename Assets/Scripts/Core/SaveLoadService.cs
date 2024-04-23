using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minidev.Core.SaveLoad
{
    public class SaveLoadService
    {
        public GameplayData Load()
        {
            string json = PlayerPrefs.GetString("SAVE");
            if (string.IsNullOrEmpty(json))
                return new GameplayData();
            else
                return JsonUtility.FromJson<GameplayData>(json);
        }

        public void Save(GameplayData data)
        {
            if(data == null)
            {
                Debug.LogError("Data doesn't null");
                return;
            }
            string json = JsonUtility.ToJson(data);
            PlayerPrefs.SetString("SAVE", json);
        }
    }
}

