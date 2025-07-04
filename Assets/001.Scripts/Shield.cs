using UnityEngine;

public class Shield : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos; 
    }
}
