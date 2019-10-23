using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public static ChangeScene Instance;
    private void Awake()
    {
        if (Instance != null) Instance = this;
        else Destroy(this);
    }

    private void Update()
    {
        RestartScene(KeyCode.R);
    }

    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    private void RestartScene(KeyCode restartButton)
    {
        if (Input.GetKeyDown(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
