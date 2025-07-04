using UnityEngine;

public class Square : MonoBehaviour
{

    private void Start()
    {
        float posX = Random.Range(-3.0f, 3.0f);
        float posY = Random.Range(3.0f, 5.0f);
        transform.position = new Vector2(posX, posY);

        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector2(size, size);
    }

    private void Update()
    {
        if(gameObject.transform.position.y < -5.6f)
        {
            Destroy(gameObject);
        }
    }
}
