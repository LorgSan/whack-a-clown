using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{

    public Text endText;
    public string replaceText;

    // Start is called before the first frame update
    void Start()
    {
        string scoreUpdate = endText.text.Replace(replaceText, ScoreTracker.scoreCount.ToString());
        endText.text = scoreUpdate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
