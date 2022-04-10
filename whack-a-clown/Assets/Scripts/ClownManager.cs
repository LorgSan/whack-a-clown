using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownManager : MonoBehaviour
{
    //GameObject jumpingClown;
    public static List<GameObject> clowns;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        clowns = new List<GameObject>();
        foreach (Transform clown in transform) 
        {
            clowns.Add(clown.gameObject);
            //Debug.Log(clown.gameObject);
        }

        Randomize();
        
    }

    public static void Randomize()
    {
        int randomIndex = Random.Range(0,9);
        //Debug.Log(randomIndex);
        GameObject jumpingClown = clowns[randomIndex];
        Debug.Log(jumpingClown.name);
        //jumpingClown.GetComponent<SpriteRenderer>().color = color;
        jumpingClown.GetComponent<ClownBehavior>().PopUp();
        
    }
}
