using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    int MaxHp;
    int CurrentHp;
    [SerializeField]
    int pointsReward;
    [SerializeField]
    Sprite[] damagedSprites;
    [SerializeField]
    AudioClip DestroyingSound;

    LevelController levelManager;
    Ball ball;
    SpriteRenderer spriteRenderer;
    int damageStage;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelController>();
        ball = FindObjectOfType<Ball>();
        CurrentHp = MaxHp;
        spriteRenderer = GetComponent<SpriteRenderer>();
        damageStage = MaxHp / damagedSprites.Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CurrentHp -= ball.Damage;

        if (CurrentHp < 1)
        {
            levelManager.OnBlockDestroying(pointsReward);
            AudioSource.PlayClipAtPoint(DestroyingSound, Camera.main.transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            for (int i = 0; i < damagedSprites.Length; i++)
                if (CurrentHp > i * damageStage && CurrentHp < (i + 1) * damageStage)
                {
                    spriteRenderer.sprite = damagedSprites[i];
                    break;
                }
        }
    }
}
