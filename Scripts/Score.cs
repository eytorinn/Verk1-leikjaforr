
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //hér notum við staðsetningu spilarans til að ákvarða stig. ("0") er notað til að það fari ekki í kommutölur
    }
}
