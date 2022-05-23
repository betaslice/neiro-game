using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetadataLoader : MonoBehaviour
{
    private SongMetadata meta;
    public Text titleText;
    public Text artistText;
    public Image jacketImage;
    public Image bgImage;
    // Start is called before the first frame update
    void Start()
    {
        meta = GetComponent<SongManager>().meta;
        titleText.text = meta.SongTitle;
        artistText.text = meta.SongArtist;
        jacketImage.sprite = meta.Jacket;
        bgImage.sprite = meta.BG;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}