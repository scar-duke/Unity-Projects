using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    

    public float movementSpeed = 10f;
    public float rotationSpeed = 50f;

    private void FixedUpdate() {

        transform.Rotate(0, Input.GetAxis("P1_horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("P1_vertical") * Time.deltaTime * movementSpeed);

    }
}
