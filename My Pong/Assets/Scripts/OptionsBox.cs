using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsBox : MonoBehaviour
{
    [SerializeField] private GameObject soundPanel;
    [SerializeField] private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        hidePanel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                PlayGame();
            } else
            {
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        showPanel();
    }

    public void PlayGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        hidePanel();
    }

    private void hidePanel()
    {
        soundPanel.SetActive(false);
    }

    private void showPanel()
    {
        soundPanel.SetActive(true);
    }

}
