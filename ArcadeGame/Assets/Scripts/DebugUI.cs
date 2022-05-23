using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DebugUI : MonoBehaviour
{
    public SongManager sm;
    public Text songPos;
    public Text songBeats;

    private bool isEnabled;

    void Start()
    {
        isEnabled = false;
        var color = songPos.color;
        color.a = 0;
        songPos.color = color;
        songBeats.color = color;
    }

    void Update()
    {
        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            isEnabled = true;
        }
        if (isEnabled)
        {
            var color = songPos.color;
            color.a = 1;
            songPos.color = color;
            songBeats.color = color;
        }

        songPos.text = (sm.songPosition / 1000).ToString();
        songBeats.text = (sm.songPositionInBeats / 1000).ToString();
    }
}
