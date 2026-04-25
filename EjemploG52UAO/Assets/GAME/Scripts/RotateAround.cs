using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target; // The target to rotate around
    public float speed = 50f; // Rotation speed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}
