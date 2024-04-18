using Minidev.Core;
using TMPro;
using UnityEngine;
using Zenject;

public class LevelText : MonoBehaviour
{
    private GameplayLogic _gameplayLogic;

    [SerializeField] private TextMeshProUGUI _level;

    private void OnEnable()
    {
        _gameplayLogic.OnGameplayDataLoaded += OnDataChanged;
        _gameplayLogic.OnGameplayDataUpdated += OnDataChanged;
    }

    private void OnDisable()
    {
        _gameplayLogic.OnGameplayDataLoaded -= OnDataChanged;
        _gameplayLogic.OnGameplayDataUpdated -= OnDataChanged;
    }

    private void OnDataChanged(GameplayData obj)
    {
        _level.text = $"Level {obj.Level + 1}";
    }

    [Inject]
    public void Construct(GameplayLogic logic)
    {
        _gameplayLogic = logic;
    }
}
