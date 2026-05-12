using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayNarration : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource narrationSource;
    public AudioSource musicSource;

    [Header("Clips")]
    public AudioClip intro;
    public AudioClip final;
    public AudioClip backgroundMusic;

    [Header("Timing")]
    public float introDelay = 3.5f;
    public float finalDelay = 1f;

    [Header("Music Settings")]
    [Range(0f, 1f)]
    public float musicVolume = 0.3f;

    private void Start()
    {
        playIntro();
    }

    public void playIntro()
    {
        StartCoroutine(PlayNarrationWithMusic(intro, introDelay));
    }

    public void playFinal()
    {
        StartCoroutine(PlayNarrationWithMusic(final, finalDelay));
    }

    private IEnumerator PlayNarrationWithMusic(AudioClip narrationClip, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Setup looping background music
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.volume = musicVolume;
        musicSource.Play();

        // Play narration
        narrationSource.clip = narrationClip;
        narrationSource.Play();

        // Wait until narration finishes
        yield return new WaitForSeconds(narrationClip.length);

        // Stop music exactly when narration ends
        musicSource.Stop();
    }
}
