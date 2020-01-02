using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("r")) {
            SceneManager.LoadScene("Game");
        }
    }
}
