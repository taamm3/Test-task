using UnityEngine;
using UnityEngine.SceneManagement;

public class AnotherSceneLoader : MonoBehaviour
{
    [SerializeField] private int _sceneIndexToLoad;

    public void LoadSceneByIndex()
    {
        SceneManager.LoadScene(_sceneIndexToLoad);
    }
}
