using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{

    public Text scoreText; //text where the score is displayed
    [SerializeField] public static int scoreCount = 0; //score starts as 0
    public Color deadbloodyclowncorpse = Color.red; //red color, to be used on clicked clowns
    AudioSource clip; //the clip that is played when a clown is clicked
    

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //lets us carry the score into the end scene, so we can display it
        clip = GetComponent<AudioSource>(); //get the clip so we can use it later
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D col = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //find whether the mouse is on the collider
                //checking if there's a line under the mouse
                

                if(col != null) //and if there is 
                {
                    

                    if(Input.GetMouseButtonDown(0))  //if you click on the collider
                    {
                          col.GetComponent<SpriteRenderer>().color=deadbloodyclowncorpse; //turn the clown red
                          col.GetComponent<BoxCollider2D>().enabled = false; //disable the collider so you can't click it multiple times and increase your score
                        
                            scoreCount++; //add one to the score

                          scoreText.text = "Clowns Bonked: " + scoreCount.ToString(); //display the new score
                    
                        clip.Play(0); //play the sound
                    }
                 }

    }
}

