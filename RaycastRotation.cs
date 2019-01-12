using UnityEngine;

public class RaycastRotation : MonoBehaviour {

    public Rigidbody ObjectRigidbody;

	void FixedUpdate () {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;


            if (playerToMouse.x < 0)
            {
                playerToMouse.z -= 1f;
            }
            else
            {
                playerToMouse.z -= 0.3f;
            }

            if (playerToMouse.z > 0)
            {
                playerToMouse.x -= 0.2f;
            }
            else
            {
                playerToMouse.x += 0.3f;
            }

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            ObjectRigidbody.MoveRotation(newRotation);
        }
    }
}
