using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;
    public float Xoffsetdelimetr = 5;
    float playerSpeed;
    public float xOffset;
    private Vector3 currvel;
    

    void FixedUpdate ()
	{

        playerSpeed = PlayerScript.xMovement;
        xOffset = playerSpeed / Xoffsetdelimetr;
        if (Mathf.Abs(playerSpeed) < 12)
        {
            transform.position = target.position;
        }
        else
        {
            if (playerSpeed > 0)
            {
                offset.x = playerSpeed / Xoffsetdelimetr;
                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothedPosition;

            }
            else
            {
                offset.x = playerSpeed / Xoffsetdelimetr;
                Vector3 desiredPosition = target.position - offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothedPosition;
            }


        }
        //Vector3 desiredPosition = target.position + offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //transform.position = smoothedPosition;

        //transform.LookAt(target);
    }

}
