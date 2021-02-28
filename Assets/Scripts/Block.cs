using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    AudioClip DestroyingSound;
    [SerializeField]
    int pointsReward;

    LevelController levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        levelManager.OnBlockDestroying(pointsReward);
        AudioSource.PlayClipAtPoint(DestroyingSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
