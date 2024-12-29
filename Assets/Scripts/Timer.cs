using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    bool active = false;
    public float currentTime;
    public Text txt;

    private void Start()
    {
        currentTime = 0;
        active = true;
    }

    private void Update()
    {
        if (active)
        {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        txt.text = time.ToString(@"mm\:ss\.ff");
    }
}