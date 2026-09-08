using UnityEngine;

public class MainScript : MonoBehaviour
{
    public Mesh playerMesh;
    public Material playerMaterial;

    void Start()
    {
        GameObject go = new GameObject();
        go.name = "Player";

        go.AddComponent<MeshFilter>();
        go.AddComponent<MeshRenderer>();
        go.AddComponent<CapsuleCollider>();
        go.AddComponent<Player>();

        MeshFilter meshFilter = go.GetComponent<MeshFilter>();
        meshFilter.mesh = playerMesh;

        MeshRenderer meshRenderer = go.GetComponent<MeshRenderer>();
        meshRenderer.material = playerMaterial;

        Player player = go.AddComponent<Player>();
        player.hp = 200;


    }

    void Update()
    {
        
    }
}
