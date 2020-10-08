
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void Update() //Þetta gerist aftur og aftur meðan leikur er í gangi
    {
        transform.position = player.position + offset; //Það sem ég er að gera hér er að setja myndavél á réttann stað. (og læt myndavél fylgja spilara)
    }
}
