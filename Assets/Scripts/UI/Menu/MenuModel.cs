
public class MenuModel 
{
    private Lives _livesData;


    public MenuModel(Lives livesData)
    {
        _livesData = livesData;
    }

    /// <summary>
    /// Get lives value
    /// </summary>
    /// <returns></returns>
    public int GetLives()
    {
        return _livesData.livesCounter;
    }
    /// <summary>
    /// Get time value
    /// </summary>
    /// <returns></returns>
    public int GetTime()
    {
        return _livesData.timerCounter;
    }
}
