using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject playButtonSprite;
    public GameObject exitButtonSprite;
    public GameObject setButtonSprite;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    public void PlaySetNormalState()
    {
        playButtonSprite.transform.localScale = new Vector2(1f, 1f);
    }
    public void PlaySetHighlightedState()
    {
        playButtonSprite.transform.localScale = new Vector2(1.3f, 1.3f);
    }

    public void ExitSetNormalState()
    {
        exitButtonSprite.transform.localScale = new Vector2(1f, 1f);
    }
    public void ExitSetHighlightedState()
    {
        exitButtonSprite.transform.localScale = new Vector2(1.3f, 1.3f);
    }

    public void SetNormalState()
    {
        setButtonSprite.transform.localScale = new Vector2(1f, 1f);
    }
    public void SetHighlightedState()
    {
        setButtonSprite.transform.localScale = new Vector2(1.3f, 1.3f);
    }

    public void SceneGame()
    {
        SceneManager.LoadScene("JumpGameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("∞‘¿” ¡æ∑·µ ");
    }
}
