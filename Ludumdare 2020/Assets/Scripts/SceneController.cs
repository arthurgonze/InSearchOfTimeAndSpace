using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private int _playLevel = 0;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(Transition(sceneIndex));
    }

    private IEnumerator Transition(int sceneIndex)
    {
        if (sceneIndex < 0)
        {
            Debug.LogError("Scene to load not set");
            yield break;
        }
        DontDestroyOnLoad(this.gameObject);

        SceneManager.LoadSceneAsync(_playLevel);
        Destroy(this.gameObject);
    }
}
