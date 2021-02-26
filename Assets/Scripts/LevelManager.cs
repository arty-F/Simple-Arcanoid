using UnityEngine;

public class LevelManager : MonoBehaviour
{
    int remainingBlocks;

    private void Start()
    {
        remainingBlocks = FindObjectsOfType<Block>().Length;
    }

    public void OnCollisionEnter()
    {
        if (--remainingBlocks < 1)
            Debug.Log("End");
    }
}

