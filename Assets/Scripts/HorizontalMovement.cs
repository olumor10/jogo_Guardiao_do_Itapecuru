using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        if (transform.position.x < -10f) // Ajuste esse valor conforme o tamanho do cenário
        {
            Destroy(gameObject);
        }
    }
}
