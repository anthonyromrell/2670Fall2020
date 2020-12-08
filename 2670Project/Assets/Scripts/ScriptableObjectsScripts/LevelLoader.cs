using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class LevelLoader : ScriptableObject
{
    public void Load(string level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Additive);
    }
}