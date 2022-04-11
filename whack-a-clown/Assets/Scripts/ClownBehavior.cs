using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClownBehavior : MonoBehaviour
{
    GameObject movingClown; //the top of the clown which jumps out
    BoxCollider2D col; //the collider
    Animator anim; //the animation
    float animLength; //how long the animation goes on for
    SpriteRenderer sexyRenderer; //the sprite renderer

    void Start()
    {
        movingClown = transform.GetChild(0).gameObject; //remember the clown object that moves, which is the first child
        col = movingClown.GetComponent<BoxCollider2D>(); //get the collider
        anim = movingClown.GetComponent<Animator>(); //get the animation
        sexyRenderer = movingClown.GetComponent<SpriteRenderer>(); //get the renderer
    }

    public void PopUp() //all the things that happen when the clown is visible/pops up!
    {
        col.enabled = true; //when the clown pops up, the collider gets enabled
        anim.Play("PopUp"); //play the pop up animation
        AnimationClip[] clips = anim.runtimeAnimatorController.animationClips; //remembers which clip is playing right noww
        foreach(AnimationClip clip in clips) //for each clip (which is 1)
        {
            animLength = clip.length; //remember its length
         
        }
        StartCoroutine(ClownDelay(animLength)); //wait for the clip duration
    }

    IEnumerator ClownDelay(float timeToWait) //the coroutine itself
    {
        yield return new WaitForSeconds (timeToWait); //the delay from when one animation starts to when the next begins
        anim.Play("Idle"); //after being played once, go back to idle
        col.enabled = false; //turn off the collider
        sexyRenderer.color = Color.white; //the clown turns red when click, so we turn it back to white so it's correctly colored for the next pop up
        ClownManager.Randomize(); //do the randomizer again, repeat with the next clown
    }
}
