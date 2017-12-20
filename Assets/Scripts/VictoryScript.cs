using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour {

    public CheckpointScript[] ListCheckpoint;
    public Dictionary<CheckpointScript,bool> ListIsPassedCheckpoint;
    public bool AllPassed;
    public Text WinText;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < ListCheckpoint.Length; i++)
        {
            bool IsPassed = false;
            ListIsPassedCheckpoint.Add(ListCheckpoint[i],IsPassed);
        }
        WinText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (ListIsPassedCheckpoint.ContainsValue(false))
        {
            AllPassed = false;
        }
        else
        {
            AllPassed = true;
        }

        if (AllPassed)
        {
            WinText.text = gameObject.name + " a gagné la course !";
            WinText.gameObject.SetActive(true);
        }
            

	}

    public void SetCheckpointPassed(CheckpointScript Checkpoint)
    {
        ListIsPassedCheckpoint[Checkpoint] = true;
    }
}
