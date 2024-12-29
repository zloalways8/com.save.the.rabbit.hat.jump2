using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Menu : MonoBehaviour
{
    public Text displayHighScore;

    void Start()
    {
        TimeSpan time = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("record"));
        
		if (time.TotalSeconds > 0)
		{
			displayHighScore.text = "HIGH SCORE\n" + time.ToString(@"mm\:ss\.ff");
		}
        else
        {
            displayHighScore.text = "HIGH SCORE\n00:00.00";
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
