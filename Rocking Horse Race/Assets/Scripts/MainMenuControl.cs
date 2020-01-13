using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public GameObject menu;
    public GameObject instructions;

    void Update()
    {
        if (Input.GetKey("a") && Input.GetKey(KeyCode.LeftArrow)) {
            menu.SetActive(false);
            instructions.SetActive(true);
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait() {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("Game");
    }
}
