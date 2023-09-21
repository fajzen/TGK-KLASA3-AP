using UnityEngine;

public class UFOCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // SprawdŸ, czy zderzenie nast¹pi³o z obiektem o nazwie "Pickup"
        if (collision.gameObject.CompareTag("Pickup"))
        {
            // Usuñ obiekt "Pickup" po zderzeniu
            Destroy(collision.gameObject);
        }
    }
}