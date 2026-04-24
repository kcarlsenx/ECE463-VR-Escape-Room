using UnityEngine;

public class PuzzleItem : MonoBehaviour
{

    private Renderer rend; // Use to set material
    public Material normalMaterial; // Default material
    public Material highlightMaterial; // Highlight material

    // Set default state of object
    void Awake()
    {
        rend = GetComponentInChildren<Renderer>();

        // Ensure we start with normal material
        if (rend != null && normalMaterial != null)
        {
            rend.material = normalMaterial;
        }
    }

    // Change object to highlight state
    public void SetHighlight(bool on)
    {
        if (rend == null) return;

        if (on && highlightMaterial != null)
        {
            rend.material = highlightMaterial;
        }
        else if (!on && normalMaterial != null)
        {
            rend.material = normalMaterial;
        }
    }

    // Triggered when object is pointed at
    public void OnHoverEnter()
    {
        SetHighlight(true);
    }

    // Triggered when objected is no longer pointed at
    public void OnHoverExit()
    {
        SetHighlight(false);
    }
}