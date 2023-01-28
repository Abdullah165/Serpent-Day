using UnityEngine.UI;
using UnityEngine;

public class SerpentScore : MonoBehaviour
{
    int score;
    int bestScore;
    [SerializeField] Text gamePlayScoreText;
    [SerializeField] Text ResultWindowScoreText;
    [SerializeField] Text ResultWindowBestScoreText;
    [SerializeField] AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
        ResultWindowBestScoreText.text = bestScore.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fly"))
        {
            score += 2;
            gamePlayScoreText.text = score.ToString();
            ResultWindowScoreText.text = score.ToString();
        }
        else if (collision.gameObject.CompareTag("Leaf"))
        {
            score++;
            gamePlayScoreText.text = score.ToString();
            ResultWindowScoreText.text = score.ToString();
        }

        if (bestScore < score)
            PlayerPrefs.SetInt("bestScore", score);

        if (PlayerPrefs.GetInt("Vibrated", 1) == 0)
        {
            Handheld.Vibrate();
        }

        if (PlayerPrefs.GetInt("Muted", 1) == 0)
        {
            audioSource.Play();
        }
    }
}
