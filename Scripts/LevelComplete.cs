
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() //Fall til að flytja spilara í næsta borð
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Færir spilara í næsta borð
    }
}
