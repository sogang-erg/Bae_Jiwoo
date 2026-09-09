using UnityEngine;

public class Challenger : MonoBehaviour
{
    public string playerName = "Challenger";
    public int hp = 100;
    public float moveSpeed = 5.0f; 

    void Start()
    {

    }

    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(h, 0, v);
        transform.position += moveDir * moveSpeed * Time.deltaTime;


        if (hp <= 0)
        {
            Debug.Log("도전자가 쓰러졌습니다. 만회할 수 있을까요?");
            Destroy(gameObject);
        }
    }
}