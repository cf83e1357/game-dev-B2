using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void StartLevel1()
    {
        SceneManager.LoadScene("Scenes/Level 1");
    }
    
    public void StartLevel2()
    {
        SceneManager.LoadScene("Scenes/Level 2");
    }
    
    public void StartLevel3()
    {
        SceneManager.LoadScene("Scenes/Level 3");
    }
}
