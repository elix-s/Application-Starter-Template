using System;
using System.Runtime.InteropServices;
using Codice.CM.ConfigureHelper;
using Common.GameStateService;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    private GameStateService _gameStateService;

    [Inject]
    private void Construct(GameStateService gameStateService)
    {
        _gameStateService = gameStateService;
    }

    private void Awake()
    {
        var user = "User";
        _startGameButton.onClick.AddListener((() => _gameStateService.ChangeState<StartGameState>(user).Forget()));
    }
}
