
using UnityEngine;

public class CollisionCounter : MonoBehaviour
{
    private int collisionCount = 0;
    private TextMesh textMesh;

    private void Start()
    {
        
        textMesh = GetComponentInChildren<TextMesh>();
    }

    private void OnCollisionEnter(Collision other)
    {
        collisionCount++;
        
        textMesh.text = "Collisions: " + collisionCount;
    }
}
