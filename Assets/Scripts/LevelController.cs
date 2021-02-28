using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    int remainingBlocks;
    SceneController sceneLoader;
    TextMeshProUGUI scoreText;
    int currentScore = 0;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneController>();
        remainingBlocks = FindObjectsOfType<Block>().Length;
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        RefreshScoreUI();
    }

    public void OnBlockDestroying(int scoreReward)
    {
        currentScore += scoreReward;
        RefreshScoreUI();

        if (--remainingBlocks < 1)
            sceneLoader.OnGameWin();
    }

    private void RefreshScoreUI()
    {
        scoreText.text = currentScore.ToString();
    }
}

