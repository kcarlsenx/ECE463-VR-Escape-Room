using UnityEngine;

public class PuzzleItem : MonoBehaviour
{
    private Vector3 startPos;
    private Quaternion startRot;
    private Vector3 startScale;

    private Renderer rend;

    public Material normalMaterial;
    public Material highlightMaterial;

    void Awake()
    {
        startPos = transform.localPosition;
        startRot = transform.localRotation;
        startScale = transform.localScale;

        rend = GetComponentInChildren<Renderer>();

        // Ensure we start with normal material
        if (rend != null && normalMaterial != null)
        {
            rend.material = normalMaterial;
        }
    }

    public void ResetItem()
    {
        transform.localPosition = startPos;
        transform.localRotation = startRot;
        transform.localScale = startScale;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

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

    public void OnHoverEnter()
    {
        SetHighlight(true);
    }

    public void OnHoverExit()
    {
        SetHighlight(false);
    }
}