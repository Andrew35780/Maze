using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private Text score;

    private int scoreCount = 0;

    private void OnEnable() => PickUpCoin.OnPickUp += AddScore;

    private void OnDisable() => PickUpCoin.OnPickUp -= AddScore;

    private void AddScore()
    {
        scoreCount++;
        score.text = $"Score: {scoreCount}";
    }
}
