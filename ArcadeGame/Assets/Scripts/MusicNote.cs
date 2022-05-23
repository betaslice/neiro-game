using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    float t;
    public Vector2 startPos;
    public Vector2 target;

    private float scrollSpeed;
    private float moveSpeed;
    private bool finished;

    public float assignedTime;
    public float assignedLane;

    float timeToReachTarget;
    private float audioTime;
    private float lastAudioTime;
    private float audioDelta;
    public SongManager sm;
    public InputManager im;

    void Start()
    {
        t = 0;
        startPos = transform.position;
        target = new Vector2(transform.position.x, -4.0f);
        sm = transform.parent.parent.parent.GetComponent<SongManager>();
        im = transform.parent.parent.parent.GetComponent<InputManager>();
        timeToReachTarget = sm.scrollTime * 1000;
        lastAudioTime = sm.songPosition;
        audioTime = lastAudioTime;
        finished = false;
        scrollSpeed = sm.scrollTime;
    }

    void Update()
    {
        if (!finished)
        {
            audioTime = sm.songPosition;
            audioDelta = audioTime - lastAudioTime;
            t = audioDelta / timeToReachTarget;
            transform.position = Vector2.Lerp(startPos, target, t);

            if (transform.position.y == target.y)
            {
                finished = true;
            }
        }

        if (finished)
        {
            float distance = target.y - startPos.y;
            moveSpeed = distance / scrollSpeed;
            Vector2 direction = (-(target - startPos)).normalized;
            transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;

            if (sm.songPosition > (assignedTime * sm.secPerBeat * 1000) + im.time4)
            {
                if (assignedLane == 1)
                {
                    sm.lowestNote1.Dequeue();
                }
                else if (assignedLane == 2)
                {
                    sm.lowestNote2.Dequeue();
                }
                else if (assignedLane == 3)
                {
                    sm.lowestNote3.Dequeue();
                }
                else if (assignedLane == 4)
                {
                    sm.lowestNote4.Dequeue();
                }

                sm.combo = 0;
                im.judge.text = "MISS";
                Destroy(gameObject); 
            }
        }
    }
}