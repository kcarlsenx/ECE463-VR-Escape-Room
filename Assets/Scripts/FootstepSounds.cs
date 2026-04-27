using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] woodClips;
    public AudioClip[] stoneClips;

    public float stepInterval = 0.55f;
    public float minMoveSpeed = 0.1f;
    public float rayDistance = 2.0f;

    private Vector3 lastPosition;
    private float stepTimer;

    void Start()
    {
        lastPosition = transform.position;

        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector3 horizontalMove = transform.position - lastPosition;
        horizontalMove.y = 0;

        float speed = horizontalMove.magnitude / Time.deltaTime;

        if (speed > minMoveSpeed)
        {
            stepTimer += Time.deltaTime;

            if (stepTimer >= stepInterval)
            {
                PlayFootstep();
                stepTimer = 0f;
            }
        }
        else
        {
            stepTimer = stepInterval;
        }

        lastPosition = transform.position;
    }

    void PlayFootstep()
    {
        AudioClip[] clips = GetCurrentFloorClips();

        if (clips == null || clips.Length == 0 || audioSource == null)
            return;

        AudioClip clip = clips[Random.Range(0, clips.Length)];

        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(clip);
    }

    AudioClip[] GetCurrentFloorClips()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, rayDistance))
        {
            if (hit.collider.CompareTag("WoodFloor"))
                return woodClips;

            if (hit.collider.CompareTag("StoneFloor"))
                return stoneClips;
        }

        return stoneClips;
    }
}