using UnityEngine;
using UnityEngine.Events;

public class BookSlot : MonoBehaviour
{
    public string requiredItemID;
    public Transform snapPoint;
    public UnityEvent onCorrectBookPlaced;

    public AudioSource audioSource;
    public AudioClip correctClip;

    private bool filled = false;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (filled)
            return;

        BookPuzzleItem item = other.GetComponent<BookPuzzleItem>();

        if (item == null)
            item = other.GetComponentInParent<BookPuzzleItem>();

        if (item == null)
            return;

        if (item.itemID != requiredItemID)
            return;

        SnapBook(item.gameObject);
        filled = true;

        if (audioSource != null && correctClip != null)
            audioSource.PlayOneShot(correctClip);

        onCorrectBookPlaced.Invoke();
    }

    private void SnapBook(GameObject book)
    {
        Rigidbody rb = book.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
        }

        book.transform.position = snapPoint.position;
        book.transform.rotation = snapPoint.rotation;
    }
}