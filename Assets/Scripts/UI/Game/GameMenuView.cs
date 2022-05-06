using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameMenuView : MonoBehaviour
{
    [SerializeField]
    private Text _textLivesCounter;
    [SerializeField]
    private Text _textTimeCounter;

    public event Action OnLivesCounterInc;
    public event Action OnLivesTimer;


    /// <summary>
    /// Init timer
    /// </summary>
    public void Init()
    {
        StartCoroutine(LivesTimer(1f)); 
    }

    #region Button events
    /// <summary>
    /// Load Menu scene
    /// </summary>
    public void OnBtnExitClick()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    /// <summary>
    /// Button increment click event
    /// </summary>
    public void OnBtnLivesClick()
    {
        if (OnLivesCounterInc != null)
            OnLivesCounterInc();
    }

    #endregion
    /// <summary>
    /// Set time value and convert in string format
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
    /// Set time value and convert in string
    /// </summary>
    /// <param name="lives"></param>
    public void SetLives(int lives)
    {
        _textLivesCounter.text = lives.ToString();
    }
    /// <summary>
    /// Timer
    /// </summary>
    /// <param name="delay"> seconds value</param>
    /// <returns></returns>
    private IEnumerator LivesTimer(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            if (OnLivesTimer != null)
            {
                OnLivesTimer();
            }
        }
      
    }
  
}
