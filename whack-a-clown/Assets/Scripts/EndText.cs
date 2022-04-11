using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{

    public Text endText; //the text itself
    public string replaceText; //the string we want to replace with the final score

    // Start is called before the first frame update
    void Start()
    {
        string scoreUpdate = endText.text.Replace(replaceText, ScoreTracker.scoreCount.ToString()); //create a string which uses scoreCount instead of the replacetext string
        endText.text = scoreUpdate; //use that string in place of the original endtext
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
