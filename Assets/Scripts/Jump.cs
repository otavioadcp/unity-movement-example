using UnityEngine;

public class Jump : MonoBehaviour
{

    public bool isAlive = true;
    public Rigidbody2D rig;
    public float jumpStr = 8;

    public MainLogicScript mainLogic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rig.linearVelocityY = jumpStr;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        mainLogic.gameOver();
        isAlive = false;
    }
}
