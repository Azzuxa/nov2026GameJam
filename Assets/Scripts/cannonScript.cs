using UnityEngine;

public class cannonScript : MonoBehaviour
{


    public GameObject prefab;
    public Transform trans;
    public float sensitivity = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X") * sensitivity;
        float rotationY = Input.GetAxis("Mouse Y") * sensitivity;
        float rotationZ = -(rotationX + rotationY) * sensitivity;

        
        transform.Rotate(Vector3.forward, rotationZ, Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = Camera.main.nearClipPlane;
            Vector2 world_pos = Camera.main.ScreenToWorldPoint(pos);
            Instantiate(prefab, world_pos, Quaternion.identity);
        }
    }
}
