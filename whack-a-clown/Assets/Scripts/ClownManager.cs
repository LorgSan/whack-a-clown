using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownManager : MonoBehaviour
{
    public static List<GameObject> clowns; //create a list to hold the clowns
    public Color color; //give them a color

    // Start is called before the first frame update
    void Start()
    {
        clowns = new List<GameObject>(); //initiate the list
        foreach (Transform clown in transform) //for each child in the gameobject
        {
            clowns.Add(clown.gameObject); //add each child to the list
        }

        Randomize(); //select a clown to appear
        
    }

    public static void Randomize()
    {
        int randomIndex = Random.Range(0,9); //pick a random clown
        GameObject jumpingClown = clowns[randomIndex]; //set the variable as the randomly chosen clown
        Debug.Log(jumpingClown.name); //print which clown was chosen in the console
        jumpingClown.GetComponent<ClownBehavior>().PopUp(); //play the pop up animation for the chosen clown
        
    }
}
