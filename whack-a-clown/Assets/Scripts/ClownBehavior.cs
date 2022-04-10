using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClownBehavior : MonoBehaviour
{
    GameObject movingClown;
    BoxCollider2D col;
    Animator anim;
    float animLength;
    SpriteRenderer sexyRenderer;

    //ClownManager clownManager; //gamemanager instance saving

    void Start()
    {
        movingClown = transform.GetChild(0).gameObject;
        col = movingClown.GetComponent<BoxCollider2D>();
        anim = movingClown.GetComponent<Animator>();
        sexyRenderer = movingClown.GetComponent<SpriteRenderer>();
        //clownManager = ClownManager.FindInstance();
    }

    public void PopUp()
    {
        col.enabled = true;
        anim.Play("PopUp");
        AnimationClip[] clips = anim.runtimeAnimatorController.animationClips;
        foreach(AnimationClip clip in clips)
        {
            animLength = clip.length;
            //Debug.Log(animLength);
        }
        StartCoroutine(ClownDelay(animLength));
    }

    IEnumerator ClownDelay(float timeToWait)
    {
        yield return new WaitForSeconds (timeToWait);
        //Debug.Log("Stopped waiting");
        anim.Play("Idle");
        col.enabled = false; 
        sexyRenderer.color = Color.white;
        ClownManager.Randomize();
    }
}
