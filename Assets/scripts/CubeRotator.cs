using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public Transform transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0));
    }
}
