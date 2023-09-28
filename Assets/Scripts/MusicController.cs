using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicController : MonoBehaviour
{
    public AudioClip GhostNormal;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayBackgroundMusicAfterIntro());
    }

    IEnumerator PlayBackgroundMusicAfterIntro()
    {
        yield return new WaitForSeconds(audioSource.clip.length); // Wait for the duration of the intro
        audioSource.clip = GhostNormal; // Change the clip to normal state ghost background
        audioSource.loop = true; // Enable looping for the background music
        audioSource.Play(); // Play the background music
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
