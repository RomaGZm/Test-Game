using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameMenuView _view;
    private GameMenuController _controller;
    private GameMenuModel _model;
   
    [SerializeField]
    private Lives _livesData;

    /// <summary>
    /// Init game menu
    /// </summary>
    private void Awake()
    {
        _livesData.livesCounter = 0;
        _livesData.timerCounter = 0;

        _model = new GameMenuModel(_livesData);
        _controller = new GameMenuController(_model, _view);
        _view.Init();
    }


    private void OnDestroy()
    {
        _controller.Destroy();
    }
}