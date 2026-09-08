using UnityEngine;

public class Player : MonoBehaviour
{   
    public string playerName = "Player";
    public int health = 100;
    public int attack = 10;
    float sumTime = 0;
    public Player target;

    void Start()
    {
        
    }

    void Update()
    {
        sumTime += Time.deltaTime;
        if (sumTime >= 1)
        {
            sumTime = 0;
            Attack();
        }
    }

    void Attack()
    {
        if (target != null)
        {
            target.health -= attack;
        }
    }
}