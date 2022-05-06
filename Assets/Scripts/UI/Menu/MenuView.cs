using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuView : MonoBehaviour
{

    [SerializeField]
    private Text _textLivesCounter;
    [SerializeField]
    private Text _textTimeCounter;

    /// <summary>
    /// Seting time value
    /// </summary>
    /// <param name="time"></param>
    public void SetTime(int time)
    {
        int min = Mathf.FloorToInt(time / 60f);
        int sec = Mathf.FloorToInt(time - min * 60);
        string time_res = string.Format("{0:0}:{1:00}", min, sec);

        _textTimeCounter.text = time_res;
    }

    /// <summary>
    /// Set lives value
    /// </summary>
    /// <param name="lives"></param>
    public void SetLives(int lives)
    {
        _textLivesCounter.text = lives.ToString();
    }

    #region ButtonEvents
    /// <summary>
    /// Cloasing the application
    /// </summary>
    public void OnBtnExitClick()
    {
        Application.Quit();
    }
    /// <summary>
    /// Load Game scene
    /// </summary>
    public void OnBtnPlayClick()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    #endregion
}
