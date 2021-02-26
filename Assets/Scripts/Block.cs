using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    AudioClip DestroyingSound;
    LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        levelManager.OnCollisionEnter();
        AudioSource.PlayClipAtPoint(DestroyingSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
