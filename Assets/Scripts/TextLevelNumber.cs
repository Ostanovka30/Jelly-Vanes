using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextLevelNumber : MonoBehaviour
{
    public Text Text;
    public Game Game;

    private void Start()
    {
        Text.text = "Level " + (Game.LevelIndex + 1).ToString();
    }
}
