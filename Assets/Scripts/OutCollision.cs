﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class OutCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("StartMenu");
    }
}
