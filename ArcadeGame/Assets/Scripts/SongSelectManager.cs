using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SongSelectManager : MonoBehaviour
{
    public GameObject songItemObj;

    public List<GameObject> songItemObjList;

    public SongMetadata[] songList;

    public EventSystem es;

    private void Start()
    {
        songList = Resources.LoadAll<SongMetadata>("Songs");
        int startY = 0;
        songItemObjList = new List<GameObject>();

        for (int i = 0; i < songList.Length; i++)
        {
            var songObject = Instantiate(songItemObj);
            songItemObjList.Add(songObject);
            songObject.GetComponent<SongButton>().songID = songList[i].SongID;
            Transform ts = songObject.GetComponent<Transform>();
            Text txt = ts.Find("Text").GetComponent<Text>();
            ts.SetParent(gameObject.transform, false);
            ts.localPosition = new Vector2(0, startY);
            txt.text = songList[i].SongTitle;
            startY += 50;
            Button btn = songObject.GetComponent<Button>();
        }

        es.firstSelectedGameObject = songItemObjList[0];
    }

    public void LoadSong(string songID)
    {
        transform.GetComponent<MenuManager>().LoadSong(songID);
    }
}
