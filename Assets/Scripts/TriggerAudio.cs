using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource playerAudioSource;
    public int waitingTime;
    public string otherObjectTag;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == otherObjectTag)
        {
            StartCoroutine(PlayAudios());
        }
    }

    IEnumerator PlayAudios()
    {
        playerAudioSource.PlayOneShot(audioClips[0]);

        yield return new WaitForSeconds(waitingTime);

        playerAudioSource.PlayOneShot(audioClips[1]);
    }

}
