using UnityEngine;

public class UFOCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Sprawd�, czy zderzenie nast�pi�o z obiektem o nazwie "Pickup"
        if (collision.gameObject.CompareTag("Pickup"))
        {
            // Usu� obiekt "Pickup" po zderzeniu
            Destroy(collision.gameObject);
        }
    }
}