using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongManager : MonoBehaviour
{
	// Chart Parser
	public ChartParser cp;

	// Song Metadata
	public SongMetadata meta;

	public SongMetadata[] songList;
	public string[] songIDList;

	public class NoteObj
    {
		public float noteTime;
		public GameObject noteObj;
    }

	//The number of seconds for each song beat
	public float secPerBeat;

	//Current song position, in seconds
	public float songPosition;

	//Current song position, in beats
	public float songPositionInBeats;

	//How many seconds have passed since the song started
	public float dspSongTime;

	//How many ms to delay notes from spawning
	public float noteOffset;

	public Queue<NoteObj> lowestNote1;
	public Queue<NoteObj> lowestNote2;
	public Queue<NoteObj> lowestNote3;
	public Queue<NoteObj> lowestNote4;
	public Queue<NoteObj> lowestNote5;
	public Queue<NoteObj> lowestNote6;
	public Queue<NoteObj> lowestNote7;

	public Transform spawn1;
	public Transform spawn2;
	public Transform spawn3;
	public Transform spawn4;
	public Transform spawn5;
	public Transform spawn6;
	public Transform spawn7;

	//an AudioSource attached to this GameObject that will play the music.
	AudioSource musicSource;

	//Note to spawn
	[SerializeField]
	public GameObject musicNote1;
	public GameObject musicNote2;
	public GameObject musicNote3;
	public GameObject musicNote4;
	public GameObject musicNote5;
	public GameObject musicNote6;
	public GameObject musicNote7;
	private GameObject spawnedNote;
	
	//Start Pos
	[SerializeField]
	public float startPos;

	//Current note to work with
	public List<object> noteValue;

	// Scroll speed calculation
	public float scrollTime;

	private int noteIndex;

	public Text comboTxt;
	public int combo;

	public Text scoreTxt;
	public int score;
	public int noteCount;

	// Use this for initialization
	void Start()
	{
		songList = Resources.LoadAll<SongMetadata>("Songs");
		songIDList = new string[songList.Length];
		for(int i = 0; i < songList.Length; i++)
        {
			songIDList[i] = songList[i].SongID;
        }

		for(int i = 0; i < songIDList.Length; i++)
        {
			if(GlobalVars.songToLoad == songIDList[i])
            {
				meta = songList[i];
            }
        }

		noteCount = int.Parse(meta.EasyNoteCount);
		StartCoroutine(StartOffset());
		combo = 0;
		score = 0;
		cp.ParseChart(meta.EasyChartFile);

		//Calculate the number of seconds in each beat
		secPerBeat = 60f / meta.SongBpm;

		noteIndex = 1;

		lowestNote1 = new Queue<NoteObj>();
		lowestNote2 = new Queue<NoteObj>();
		lowestNote3 = new Queue<NoteObj>();
		lowestNote4 = new Queue<NoteObj>();
		lowestNote5 = new Queue<NoteObj>();
		lowestNote6 = new Queue<NoteObj>();
		lowestNote7 = new Queue<NoteObj>();
	}

	private IEnumerator StartOffset()
	{
		yield return new WaitForSeconds(3);

		//Load the AudioSource attached to the Conductor GameObject
		musicSource = GetComponent<AudioSource>();
		musicSource.clip = meta.SongAudio;

		//Record the time when the music starts
		dspSongTime = (float)AudioSettings.dspTime;

		//Start the music
		musicSource.Play();

	}

	// Update is called once per frame
	void Update()
	{

		//calculate the position in milliseconds
		songPosition = (float)((AudioSettings.dspTime - dspSongTime) * 1000);

		//calculate the position in beats
		songPositionInBeats = songPosition / secPerBeat;

		// Update combo text
		comboTxt.text = combo.ToString();

		// Update score text
		scoreTxt.text = (score / 1000000.0f * 100f).ToString("00.00") + "%";

		if (cp.GetAnyValue(noteIndex.ToString()) as List<object> != null)
		{

			noteValue = cp.GetAnyValue(noteIndex.ToString()) as List<object>;
			float noteTime = float.Parse(noteValue[1].ToString()) * secPerBeat * 1000;

			// Check if the note is ahead of the current song position, then if it's set to pass before the next frame; process the note
			if ((noteTime > songPosition + noteOffset) && (noteTime - (scrollTime * 1000) < songPosition + (Time.deltaTime * 1000) + noteOffset))
			{
				if (float.Parse(noteValue[0].ToString()) == 1)
				{
					spawnedNote = Instantiate(musicNote1, spawn1.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote1.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				if (float.Parse(noteValue[0].ToString()) == 2)
				{
					spawnedNote = Instantiate(musicNote2, spawn2.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote2.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				if (float.Parse(noteValue[0].ToString()) == 3)
				{
					spawnedNote = Instantiate(musicNote3, spawn3.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote3.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				if (float.Parse(noteValue[0].ToString()) == 4)
				{
					spawnedNote = Instantiate(musicNote4, spawn4.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote4.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				if (float.Parse(noteValue[0].ToString()) == 5)
				{
					spawnedNote = Instantiate(musicNote5, spawn5.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote5.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				if (float.Parse(noteValue[0].ToString()) == 6)
				{
					spawnedNote = Instantiate(musicNote6, spawn6.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote6.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				if (float.Parse(noteValue[0].ToString()) == 7)
				{
					spawnedNote = Instantiate(musicNote7, spawn7.transform);
					NoteObj noteThingy = new NoteObj();
					noteThingy.noteObj = spawnedNote;
					noteThingy.noteTime = noteTime;
					lowestNote7.Enqueue(noteThingy);
					spawnedNote.GetComponent<MusicNote>().assignedTime = float.Parse(noteValue[1].ToString());
					spawnedNote.GetComponent<MusicNote>().assignedLane = float.Parse(noteValue[0].ToString());
				}

				noteIndex += 1;
			}
		}
	}
}