using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenManagerScript : MonoBehaviour {
    //Values
    public int CurrentDay = 0;
    public int CurrentHour = 0;
    public int CurrentMinute = 0;
    public double CurrentSecond = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Update the time of the garden.
        CurrentSecond = CurrentSecond + 5;

        // Check if CurrentSecond is at least 60 and if so then increment the minute by 1
        if (CurrentSecond >= 60) {
            CurrentSecond = CurrentSecond - 60;
            CurrentMinute = CurrentMinute + 1;
        }

        // Check if CurrentMinute is at least 60 and if so then increment the minute by 1
        if (CurrentMinute >= 60)
        {
            CurrentMinute = CurrentMinute - 60;
            CurrentHour = CurrentHour + 1;
        }

        // Check if CurrentHour is at least 24 and if so then increment the minute by 1
        if (CurrentHour >= 24)
        {
            CurrentHour = CurrentHour - 24;
            CurrentDay = CurrentDay + 1;
        }
    }
}
