using UnityEngine;

public class Boss : MonoBehaviour
{
    public Challenger target;
    public Light safeLight;
    public float safeRadius = 5.0f;

    float timer = 0f;
    bool hasChecked = false;

    void Start()
    {

    }

    void Update()
    {
        if (target == null)
        {
            target = GameObject.FindFirstObjectByType<Challenger>();
            return;
        }

        if (hasChecked) return;

        timer += Time.deltaTime;

        if (timer >= 10.0f)
        {
            hasChecked = true;
            CheckPlayerInLight();
        }
    }

    void CheckPlayerInLight()
    {
        if (safeLight == null || target == null) return;


        float distance = Vector3.Distance(safeLight.transform.position, target.transform.position);

        if (distance <= safeRadius)
        {
            Debug.Log("조명 속에서 네 모습을 뽐내 봐!");
        }
        else
        {
            Debug.Log("도전자가 쓰러졌습니다! 만회할 수 있을까요?");
            target.hp -= target.hp;
        }
    }
}