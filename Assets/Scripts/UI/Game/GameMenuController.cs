using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuController
{
    private GameMenuModel Model {get; set;}
    private GameMenuView View { get; set; }

    /// <summary>
    /// Init events
    /// </summary>
    /// <param name="model"></param>
    /// <param name="view"></param>
    public GameMenuController(GameMenuModel model, GameMenuView view)
    {
        Model = model;
        View = view;

        View.OnLivesCounterInc +=  Model.LivesCounterInc;
        Model.OnLivesCounterChanged += View.SetLives;

        View.OnLivesTimer += Model.TimeCounterInc;
        Model.OnTimeCounterChanged += View.SetTime;

    }
    
    /// <summary>
    /// Clear events
    /// </summary>
    public void Destroy()
    {
        View.OnLivesCounterInc -= Model.LivesCounterInc;
        Model.OnLivesCounterChanged -= View.SetLives;

        View.OnLivesTimer -= Model.TimeCounterInc;
        Model.OnTimeCounterChanged -= View.SetTime;
    }
    
}
