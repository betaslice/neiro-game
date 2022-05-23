using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartParser : MonoBehaviour
{
	private string[] chartFileLines;
	private string[] chartValues;
	private List<object> noteValue;
	private SongMetadata meta;
	private static Dictionary<string, List<object>> dict;
	private List<string> noteLines;
	private int noteIndex;
	private int currentNumber;
	private float noteTime;

    private void Start()
    {
		noteIndex = 0;
    }

    private static void Add(string strKey, object dataType)
    {
		if (!dict.ContainsKey(strKey))
		{
			dict.Add(strKey, new List<object> { dataType });
        }
		else
        {
			dict[strKey].Add(dataType);
        }
    }

	public object GetAnyValue(string strKey)
	{
		List<object> obj;

		dict.TryGetValue(strKey, out obj);

		return obj;
	}

	public void ParseChart (TextAsset chartFile)
    {
		chartFileLines = chartFile.text.Split(); // Take text file and turn it into a string array
		dict = new Dictionary<string, List<object>>();

		foreach (string line in chartFileLines)
		{
			chartValues = line.Split(',');
			for (int i = 1; i < chartValues.Length; ++i)
			{
				Add(chartValues[0], chartValues[i]);
			}
		}
	}

	public void ParseStepmaniaChart (TextAsset chartfile)
    {
		noteLines = new List<string>();
		noteIndex = 0;
		currentNumber = 0;
		chartFileLines = chartfile.text.Split('\n');
		dict = new Dictionary<string, List<object>>();

		int index = 0;
		foreach (string line in chartFileLines)
		{
			if (line.StartsWith("#") || line.StartsWith("//"))
			{
				continue;
			}

			else if (line.StartsWith("     dance"))
			{
				index += 1;
			}

			if (index > 0 && index < 6)
			{
				index += 1;
				continue;
			}

			if (index == 6)
			{
				index += 1;
			}


			if (line.StartsWith(","))
			{
				if (noteLines.Count == 4)
				{
					for (int i = 0; i < noteLines.Count; i++)
					{
						if (noteLines[i] == "00000000")
						{
							continue;
						}

						currentNumber += 1;
						noteTime = 0;
						int noteLane = noteLines[i].IndexOf('1') + 1;
						if (noteIndex != 0)
						{
							noteTime = (noteIndex * 4) + i;
						}
						else if (noteIndex == 0)
						{
							noteTime = 4 + i;
						}

						string[] chartVal = new string[3];
						chartVal[0] = currentNumber.ToString();
						chartVal[1] = noteLane.ToString();
						chartVal[2] = noteTime.ToString();

						for (int j = 0; j < chartVal.Length; ++j)
						{
							Add(chartVal[0], chartVal[j]);
						}
					}
					noteLines.Clear();
					noteIndex += 1;
				}
			}

			if (noteLines.Count == 8)
			{
				for (int i = 0; i < noteLines.Count; i++)
				{
					if (noteLines[i] == "00000000")
					{
						continue;
					}

					currentNumber += 1;

					int noteLane = noteLines[i].IndexOf('1') + 1;
					if (noteIndex != 0)
					{
						float noteTime = (noteIndex * 4) + (i / 2);
					}
					else if (noteIndex == 0)
                    {
						float noteTime = 4 + (i / 2);
                    }

					string[] chartVal = new string[3];
					chartVal[0] = currentNumber.ToString();
					chartVal[1] = noteLane.ToString();
					chartVal[2] = noteTime.ToString();

					for (int j = 0; j < chartVal.Length; ++j)
					{
						Add(chartVal[0], chartVal[j]);
					}
				}
				noteLines.Clear();
				noteIndex += 1;
			}
			if (line.StartsWith("0") || line.StartsWith("1"))
			{
				noteLines.Add(line);
			}
		}
	}
}