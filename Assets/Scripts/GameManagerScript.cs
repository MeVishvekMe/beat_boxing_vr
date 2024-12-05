using System.Text;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    private int _score = 0;
    private float _multiplier = 1;

    void Start() {
        UpdateScoreText();
    }
    
    public void IncreaseScore() {
        _multiplier += 0.1f;
        _score += (int)(10 * _multiplier);
        UpdateScoreText();
    }

    public void ResetMultiplier() {
        _multiplier = 1;
        UpdateScoreText();
    }

    private void UpdateScoreText() {
        StringBuilder sb = new StringBuilder();
        sb.Append(_score + "\n");
        sb.Append("x" + _multiplier.ToString("F1"));  // Format multiplier to one decimal place
        scoreText.text = sb.ToString();
    }
    
}
