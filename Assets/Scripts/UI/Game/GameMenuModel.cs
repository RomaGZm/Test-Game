
using System;

public class GameMenuModel
{
    public event Action<int> OnLivesCounterChanged;
    public event Action<int> OnTimeCounterChanged;

    private Lives _livesData;

    /// <summary>
    /// Data in the Constructor
    /// </summary>
    /// <param name="livesData"></param>
    public GameMenuModel(Lives livesData)
    {
        _livesData = livesData;
    }
   
    /// <summary>
    /// Increment lives
    /// </summary>
    public void LivesCounterInc()
    {
        if (_livesData.timerCounter >= 100) return;
            _livesData.livesCounter ++;
        LivesCounterChanged();
    }
    /// <summary>
    /// Calling lives change event
    /// </summary>
    public void LivesCounterChanged()
    {
        if (OnLivesCounterChanged != null)
            OnLivesCounterChanged(_livesData.livesCounter);
    }
    /// <summary>
    /// Increment time
    /// </summary>
    public void TimeCounterInc()
    {
        _livesData.timerCounter++;
        TimeCounterChanged();
    }
    /// <summary>
    /// Calling time change event
    /// </summary>
    public void TimeCounterChanged()
    {
        if (OnTimeCounterChanged != null)
            OnTimeCounterChanged(_livesData.timerCounter);
    }
   
   
}
