using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{

    public float movementSpeed = 10f;
    public float rotationSpeed = 50f;

    private void FixedUpdate() {

        transform.Rotate(0, Input.GetAxis("P2_horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("P2_vertical") * Time.deltaTime * movementSpeed);
    }
}
