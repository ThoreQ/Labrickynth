using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameManager gameManager;

    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            gameManager.CompleteLevel();
            Destroy(gameObject);
        }
    }
}
