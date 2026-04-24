using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float openAngle;
    public float duration; 
    public bool unlocked = false;

    private float elapsed = 0f;
    private Quaternion startRot;
    private Quaternion targetRot;

    void Start()
    {
        startRot = transform.rotation;
        targetRot = startRot * Quaternion.Euler(0f, 0f, openAngle);
    }

    void FixedUpdate()
    {
        if (elapsed < duration && unlocked)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;

            transform.rotation = Quaternion.Lerp(startRot, targetRot, t);
        }
    }

    public void unlockDoor()
    {
        unlocked = true;
    }
}