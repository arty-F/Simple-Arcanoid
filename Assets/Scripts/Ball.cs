using Assets.Scripts;
using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    AudioClip[] paddleCollisionSounds;
    [SerializeField]
    AudioClip[] wallCollisionSounds;
    [SerializeField]
    AudioClip[] blockCollisionSounds;
    [SerializeField]
    AudioClip[] ballCollisionSounds;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Enum.TryParse(collision.gameObject.name, out CollisionObjects obj))
        {
            GetComponent<AudioSource>().PlayOneShot(obj switch
            {
                CollisionObjects.Paddle => GetRandomClip(paddleCollisionSounds),
                CollisionObjects.Ball => GetRandomClip(ballCollisionSounds),
                CollisionObjects.Block => GetRandomClip(blockCollisionSounds),
                _ => GetRandomClip(wallCollisionSounds)
            });
        }
    }

    private AudioClip GetRandomClip(AudioClip[] clips) => clips[UnityEngine.Random.Range(0, clips.Length)];
}
