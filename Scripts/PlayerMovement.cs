using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // hér breytum við nafni á Rigibody component í einfalt "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;
    // "Start" gerist þegar við setjum leikinn í gang (Aðeins einu sinni í hverri keyrslu)
    void Start()
    {
     
    }
    
    // Breytti þessu í "FixedUpdate" því erum að leika okkur með þyngdarafl og hreyfingu
    // "Update" eða "FixedUpdate" heldur áfram á meðan leikurinn er í gangi
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //sendum hlutinn áfram

        if (Input.GetKey("d") )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
