using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collider) {
        if(collider.collider.name == "Finish Line") {
            FindObjectOfType<GameManager>().EndGame(this.name);
        }
    }

}
