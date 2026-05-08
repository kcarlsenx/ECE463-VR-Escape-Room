using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveManager : MonoBehaviour
{
    public StoveKnob[] knobs;
    public int[] solution = { 1, 3, 0, 2, 1 };

    public BurnerEffect[] burnerEffects;

    public Animator broilerAnimator;
    public GameObject murderWeapon;
    public AudioSource suspenseAudio;
    public AudioClip suspenseClip;

    private bool solved = false;

    public void OnKnobTurned()
    {
        UpdateBurners();
        CheckSolution();
    }

    private void CheckSolution()
    {

        if (solved) return;

        for (int i = 0; i < solution.Length; i++)
        {
            if (knobs[i].currentState != solution[i])
            {
                return;
            }
        }

        solved = true;
        Debug.Log("Stove puzzle solved!");

        if (broilerAnimator != null)
            broilerAnimator.Play("OpenOven");

        if (murderWeapon != null)
            murderWeapon.SetActive(true);

        playSuspenseSound();
    }


    private void UpdateBurners()
    {
        if (burnerEffects.Length > 0 && burnerEffects[0] != null)
            burnerEffects[0].SetBurnerState(knobs[0].currentState);

        if (burnerEffects.Length > 1 && burnerEffects[1] != null)
            burnerEffects[1].SetBurnerState(knobs[1].currentState);

        if (burnerEffects.Length > 2 && burnerEffects[2] != null)
            burnerEffects[2].SetBurnerState(knobs[4].currentState); // Burner 3 uses right knob

        if (burnerEffects.Length > 3 && burnerEffects[3] != null)
            burnerEffects[3].SetBurnerState(knobs[3].currentState);
    }

    private void playSuspenseSound()
    {
        if (suspenseAudio != null && suspenseClip != null)
        {
            suspenseAudio.PlayOneShot(suspenseClip);
        }
    }

}