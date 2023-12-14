using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FootstepAudio : MonoBehaviour
{
    public float movementThreshold = 0.1f;  // Adjust this value based on your movement sensitivity
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check if the XR Rig is moving
        float movement = Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"));

        // Play audio if movement is above the threshold
        if (movement > movementThreshold && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        // Stop audio if movement is below the threshold
        else if (movement < movementThreshold && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
