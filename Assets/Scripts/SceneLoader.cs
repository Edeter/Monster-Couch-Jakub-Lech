using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] SceneLoad sceneLoad;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        sceneLoad.LoadMainMenuAction += LoadMainMenu;
        sceneLoad.LoadGameAction += LoadGame;
    }
    private void OnDisable()
    {
        sceneLoad.LoadMainMenuAction -= LoadMainMenu;
        sceneLoad.LoadGameAction -= LoadGame;
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        SceneManager.UnloadSceneAsync("Ui");
    }
    public void LoadMainMenu()
    {

        SceneManager.LoadScene("Ui");
        SceneManager.UnloadSceneAsync("Game");
    }
}
