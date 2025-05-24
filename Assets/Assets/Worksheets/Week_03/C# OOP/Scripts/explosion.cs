using UnityEngine;

public class explosion : MonoBehaviour
{
    public void Explode()
    {
        Debug.Log("Boom!");
        Destroy(gameObject);
    }
}

