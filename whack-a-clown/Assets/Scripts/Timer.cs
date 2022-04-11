using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime; //what it says on the tin- current time!
    public float startingTime = 10f; //start time set to 10, although different in inspector
    bool SceneLoaded = false; // end scene is initially not loaded- because LoadScene(); is called in update, we don't want it to endlessly load the scene each frame

    public Text countdownText; //timer text

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime; //current time is start time
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; //decrease current time at one second per second
        countdownText.text = currentTime.ToString("0"); //update the text to current time

        if (currentTime <= 0)
        {
            currentTime = 0; //don't go into the negatives, just stop at 0
            if(SceneLoaded == false) //if you're not in the end scene
            {    LoadScene(); } //load that end scene!
        }
    }

    void LoadScene()
    {
        SceneLoaded = true; //the end scene is now loaded
        SceneManager.LoadScene("ItsOver"); //load it for real
    }
}
