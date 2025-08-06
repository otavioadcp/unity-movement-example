using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody2D rig;
    public float jumpStr = 8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.linearVelocityY = jumpStr;
        }
    }
}
