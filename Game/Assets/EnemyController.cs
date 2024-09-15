using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform Player; 
    public float moveSpeed = 3f; 

    private void Update()
    {
        if (Player != null)
        {
            transform.LookAt(Player);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
