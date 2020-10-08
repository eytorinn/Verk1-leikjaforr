
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

   void OnCollisionEnter(Collision collisionInfo) //fall fyrir þegar spilari klessir á, köllum á upplýsingar
    {
        if (collisionInfo.collider.tag == "Obstacle") //Ef spilari klessir á obstacle (ekki jörðina)
        {
            movement.enabled = false; //Þá slökknar á hreyfingu og borðið endurræsir sig
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
