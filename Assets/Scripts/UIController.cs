using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject runLengthText;

    private float length = 0f;
    private float speed = 5f;

    private bool isGameOver = false;

    void Start()
    {
        gameOverText = GameObject.Find("GameOver");
        runLengthText = GameObject.Find("RunLength");
    }

    void Update()
    {
        if (isGameOver == false)
        {
            length += speed * Time.deltaTime;
            runLengthText.GetComponent<Text>().text = "Distance: " + length.ToString("F2") + "M";
        }

        if (isGameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("JumpGameScene");
            }
        }
    }

    public void GameOver()
    {
        gameOverText.GetComponent<Text>().text = "Game Over";
        isGameOver = true;
    }
}
