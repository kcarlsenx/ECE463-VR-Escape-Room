using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float openAngle; // How far the door opens
    public float duration; // How long it takes to open
    public bool unlocked = false; // Is the door locked

    private float elapsed = 0f; // Time since door opened
    private Quaternion startRot; // Closed door angle
    private Quaternion targetRot; // Open door angle

    // Calculate door posistion
    void Start()
    {
        startRot = transform.rotation;
        targetRot = startRot * Quaternion.Euler(0f, 0f, openAngle);
    }

    // Open the door when unlocked
    void FixedUpdate()
    {
        if (elapsed < duration && unlocked)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;

            transform.rotation = Quaternion.Lerp(startRot, targetRot, t);
        }
    }

    // Unlock the door
    public void unlockDoor()
    {
        unlocked = true;
    }
}