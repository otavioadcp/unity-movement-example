using UnityEngine;

public class ScoreZoneScript : MonoBehaviour
{
    public MainLogicScript mainLogic;



    void Start()
    {
        mainLogic = GameObject
                        .FindGameObjectWithTag("Logic")
                        .GetComponent<MainLogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            mainLogic.addScore();
        }
    }
}
