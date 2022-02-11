using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinText : MonoBehaviour
{
    public Text Text;
    public Game Game;

    private void Start()
    {
        Text.text = "Level " + (Game.LevelIndex).ToString() + " Passed";
    }
}
