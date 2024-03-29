﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : Menu<MainMenu>
{
    public void OnPlayPressed()
    {
        LevelLoader.LoadNextLevel();
        base.OnBackPressed();
        GameMenu.Open();
    }

    public void OnSettingsPressed()
    {
        SettingsMenu.Open();
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
