using UnityEngine;

public class GroundChecker : MonoBehaviour {
        
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            PlayerScript.grounded = true;
        }
        

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            PlayerScript.grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            PlayerScript.grounded = false;
        }
    }
}
