using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongButton : MonoBehaviour
{
    public Button thisBtn;
    public string songID;

    private void Start()
    {
        if(songID == null)
        {
            songID = "void";
        }
        thisBtn = GetComponent<Button>();
        thisBtn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        transform.parent.GetComponent<SongSelectManager>().LoadSong(songID);
    }

}
