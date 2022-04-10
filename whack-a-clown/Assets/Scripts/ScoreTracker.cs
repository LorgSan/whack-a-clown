using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{

    public Text scoreText;
    [SerializeField] public static int scoreCount = 0;
    public Color deadbloodyclowncorpse = Color.red;
    AudioSource clip;
    

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        clip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D col = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                //checking if there's a line under the mouse
                

                if(col != null) //and if there is 
                {
                    

                    if(Input.GetMouseButtonDown(0))  //on button down we do the creating line function
                    {
                          col.GetComponent<SpriteRenderer>().color=deadbloodyclowncorpse;
                          col.GetComponent<BoxCollider2D>().enabled = false;
                        
                            scoreCount++;

                          scoreText.text = "Clowns Bonked: " + scoreCount.ToString();
                    
                        clip.Play(0);
                    }
                 }

    }
}

