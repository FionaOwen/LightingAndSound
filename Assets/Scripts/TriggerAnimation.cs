using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator npcAnimation;
    public string[] animationName;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            npcAnimation.Play(animationName[0]);
        }
    }
}
