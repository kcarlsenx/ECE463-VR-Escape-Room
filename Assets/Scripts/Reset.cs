using UnityEngine;

public class PuzzleItemDebugger : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // press R to reset
        {
            GameObject[] items = GameObject.FindGameObjectsWithTag("PuzzleItem");

            foreach (GameObject obj in items)
            {
                PuzzleItem pi = obj.GetComponent<PuzzleItem>();
                if (pi != null)
                    pi.ResetItem();
            }

            Debug.Log("All puzzle items reset!");
        }
    }
}