using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public SongManager sm;
    [SerializeField]
    private float difference;
    [SerializeField]
    public float time1;
    [SerializeField]
    public float time2;
    [SerializeField]
    public float time3;
    [SerializeField]
    public float time4;

    [SerializeField]
    private GameObject laneResponse1;
    [SerializeField]
    private GameObject laneResponse2;
    [SerializeField]
    private GameObject laneResponse3;
    [SerializeField]
    private GameObject laneResponse4;
    [SerializeField]
    private GameObject laneResponse5;
    [SerializeField]
    private GameObject laneResponse6;
    [SerializeField]
    private GameObject laneResponse7;

    public Text judge;

    // Update is called once per frame

    private void Start()
    {
        judge.text = "";
    }
    void Update()
    {
        var keeb = Keyboard.current;

        if (keeb.zKey.wasPressedThisFrame)
        {
            if (sm.lowestNote1.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote1.Peek().noteTime;
                Judge(difference, 1);
            }
        }

        if (keeb.sKey.wasPressedThisFrame)
        {

            if (sm.lowestNote2.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote2.Peek().noteTime;
                Judge(difference, 2);
            }
        }

        if (keeb.xKey.wasPressedThisFrame)
        {

            if (sm.lowestNote3.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote3.Peek().noteTime;
                Judge(difference, 3);
            }
        }

        if (keeb.dKey.wasPressedThisFrame)
        {
            if (sm.lowestNote4.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote4.Peek().noteTime;
                Judge(difference, 4);
            }
        }

        if(keeb.cKey.wasPressedThisFrame)
        {

            if(sm.lowestNote5.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote5.Peek().noteTime;
                Judge(difference, 5);
            }
        }

        if (keeb.fKey.wasPressedThisFrame)
        {
            if (sm.lowestNote6.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote6.Peek().noteTime;
                Judge(difference, 6);
            }
        }

        if (keeb.vKey.wasPressedThisFrame)
        {
            if (sm.lowestNote7.Count == 0)
            {
                return;
            }
            else
            {
                difference = sm.songPosition + sm.noteOffset - sm.lowestNote7.Peek().noteTime;
                Judge(difference, 7);
            }
        }


        // Key response illumination

        if(keeb.zKey.isPressed)
        {
            var laneColor = laneResponse1.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse1.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if(!keeb.zKey.isPressed)
        {
            var laneColor = laneResponse1.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse1.GetComponent<SpriteRenderer>().color = laneColor;
        }

        if (keeb.sKey.isPressed)
        {
            var laneColor = laneResponse2.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse2.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if (!keeb.sKey.isPressed)
        {
            var laneColor = laneResponse2.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse2.GetComponent<SpriteRenderer>().color = laneColor;
        }

        if (keeb.xKey.isPressed)
        {
            var laneColor = laneResponse3.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse3.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if (!keeb.xKey.isPressed)
        {
            var laneColor = laneResponse3.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse3.GetComponent<SpriteRenderer>().color = laneColor;
        }

        if (keeb.dKey.isPressed)
        {
            var laneColor = laneResponse4.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse4.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if (!keeb.dKey.isPressed)
        {
            var laneColor = laneResponse4.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse4.GetComponent<SpriteRenderer>().color = laneColor;
        }

        if (keeb.cKey.isPressed)
        {
            var laneColor = laneResponse5.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse5.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if (!keeb.cKey.isPressed)
        {
            var laneColor = laneResponse5.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse5.GetComponent<SpriteRenderer>().color = laneColor;
        }

        if (keeb.fKey.isPressed)
        {
            var laneColor = laneResponse6.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse6.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if (!keeb.fKey.isPressed)
        {
            var laneColor = laneResponse6.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse6.GetComponent<SpriteRenderer>().color = laneColor;
        }

        if (keeb.vKey.isPressed)
        {
            var laneColor = laneResponse7.GetComponent<SpriteRenderer>().color;
            laneColor.a = 1;
            laneResponse7.GetComponent<SpriteRenderer>().color = laneColor;
        }
        else if (!keeb.vKey.isPressed)
        {
            var laneColor = laneResponse7.GetComponent<SpriteRenderer>().color;
            laneColor.a = 0;
            laneResponse7.GetComponent<SpriteRenderer>().color = laneColor;
        }
    }

    void Judge(float diff, int lane)
    {
        if (difference > -time3 && difference < time3)
        {
            if (diff > -time1 && diff < time1)
            {
                judge.text = "EXCEED";
                sm.score += 1000000 / sm.noteCount;
            }

            else if (diff > -time2 && diff < time2)
            {
                judge.text = "PERFECT";
                sm.score += 1000000 / sm.noteCount / 3 * 2;
            }

            else if (diff > -time3 && diff < time3)
            {
                judge.text = "GREAT";
                sm.score += 1000000 / sm.noteCount / 3;
            }

            if (lane == 1)
            {
                Destroy(sm.lowestNote1.Peek().noteObj);
                sm.lowestNote1.Dequeue();
            }
            else if (lane == 2)
            {
                Destroy(sm.lowestNote2.Peek().noteObj);
                sm.lowestNote2.Dequeue();
            }
            else if (lane == 3)
            {
                Destroy(sm.lowestNote3.Peek().noteObj);
                sm.lowestNote3.Dequeue();
            }
            else if (lane == 4)
            {
                Destroy(sm.lowestNote4.Peek().noteObj);
                sm.lowestNote4.Dequeue();
            }
            else if (lane == 5)
            {
                Destroy(sm.lowestNote5.Peek().noteObj);
                sm.lowestNote5.Dequeue();
            }
            else if (lane == 6)
            {
                Destroy(sm.lowestNote6.Peek().noteObj);
                sm.lowestNote6.Dequeue();
            }
            else if (lane == 7)
            {
                Destroy(sm.lowestNote7.Peek().noteObj);
                sm.lowestNote7.Dequeue();
            }

            sm.combo += 1;
            
        }
    }
}