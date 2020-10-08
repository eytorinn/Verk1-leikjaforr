
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() //Hér bý ég til fall sem lætur spilara klára borðið þegar hann "skellur" á ósýnilegan kubb sem er í enda borðsins
    {
        gameManager.CompleteLevel(); //Þá kemur upp mynd sem segir "Þú vannst borðið"
    }
}
