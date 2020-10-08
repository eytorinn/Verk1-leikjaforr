
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f; //Setjum upp public float fyrir restartdelay til að vita hversu lengi við bíðum eftir að við töpum í borði.

    public GameObject completeLevelUI; //Hér vísum við á UI sem kemur upp þegar við klárum borð "Þú vannst"

    public void CompleteLevel() //Fallið sem er notað til að birta "Þú vannst" þegar maður klárar borð
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()  //Fall sem keyrir þegar spilari tapar.
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("Game Over"); //Sendir í console "Game Over"
            Invoke("Restart", restartDelay); //Restartar borðinu
        }

    }
    void Restart() //Fall fyrir restart
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}