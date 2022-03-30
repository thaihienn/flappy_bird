
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl ins ;
    public bool GameOver = false;

    public Text scoreText;
    public GameObject gameOverText;

    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (ins == null)
            ins = this;
        else if (ins != null)
            Destroy(ins);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
            if (Input.GetKey(KeyCode.Space))
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BirdScore()
    {
        score++;
        scoreText.text = "SCORE =  " + score.ToString();
    }
    public void BirdDie()
    {
        GameOver = true;
        gameOverText.SetActive(true);
    }
}
