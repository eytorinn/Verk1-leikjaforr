
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame() //Fall fyrir takkann í menu til að byrja leikinn
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Notum sömu skipun og þegar við förum í næsta borð
    }

}
