using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public GameObject square;


    private void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1.0f);
    }

    void MakeSquare()
    {
        Instantiate(square);        // Prefabs 생성시키는 코드
        Debug.Log("네모 생성");
    }


}
