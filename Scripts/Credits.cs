
using UnityEngine;

public class Credits : MonoBehaviour
{ //Bý hér til fallið "Quit" til þess að loka leiknum og assigna það síðan við takka.
   public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
