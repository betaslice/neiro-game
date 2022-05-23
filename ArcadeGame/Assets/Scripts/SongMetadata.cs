using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Song Metadata", menuName = "Song Metadata/New Song")]
public class SongMetadata : ScriptableObject
{
    [SerializeField] string songTitle;
    [SerializeField] string songArtist;
    [SerializeField] string songGenre;
    [SerializeField] string songID;
    [SerializeField] int songBpm;
    [SerializeField] Sprite jacket;
    [SerializeField] Sprite bg;
    [SerializeField] AudioClip songAudio;

    [SerializeField] int easyDiffNumber;
    [SerializeField] string easyNoteCount;
    [SerializeField] TextAsset easyChartFile;

    [SerializeField] int normalDiffNumber;
    [SerializeField] string normalNoteCount;
    [SerializeField] TextAsset normalChartFile;

    [SerializeField] int hardDiffNumber;
    [SerializeField] string hardNoteCount;
    [SerializeField] TextAsset hardChartFile;

    public string SongTitle
    {
        get { return songTitle; }
    }

    public string SongID
    {
        get { return songID; }
    }

    public string SongArtist
    {
        get { return songArtist; }
    }

    public string SongGenre
    {
        get { return songGenre; }
    }

    public int SongBpm
    {
        get { return songBpm; }
    }

    public Sprite Jacket
    {
        get { return jacket; }
    }

    public Sprite BG
    {
        get { return bg; }
    }

    public AudioClip SongAudio
    {
        get { return songAudio; }
    }

    public int EasyDiffNumber
    {
        get { return easyDiffNumber; }
    }

    public string EasyNoteCount
    {
        get { return easyNoteCount; }
    }

    public TextAsset EasyChartFile
    {
        get { return easyChartFile; }
    }

    public int NormalDiffNumber
    {
        get { return normalDiffNumber; }
    }

    public string NormalNoteCount
    {
        get { return normalNoteCount; }
    }

    public TextAsset NormalChartFile
    {
        get { return normalChartFile; }
    }

    public int HardDiffNumber
    {
        get { return hardDiffNumber; }
    }

    public string HardNoteCount
    {
        get { return hardNoteCount; }
    }

    public TextAsset HardChartFile
    {
        get { return hardChartFile; }
    }
}
