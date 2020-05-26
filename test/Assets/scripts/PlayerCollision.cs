
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public mom movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {

        //Debug.Log(collisionInfo.collider.name);
        //while (collisionInfo.collider.tag != "ground")
        //{
        //    FindObjectOfType<mom>().Jump();
        //    movement.up = 0;
        //}
        if (collisionInfo.collider.tag == "cubes"|| collisionInfo.collider.tag == "Amood")
        {
            Debug.Log("we hit a cube!");
            
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.name == "PortalLevelOne")
        {
            Debug.Log("we hit a portal!");
            FindObjectOfType<GameManager>().NextLevel02();
        }

        if (collisionInfo.collider.name == "PortalLevelTwo")
        {
            Debug.Log("we hit a portal!");
            FindObjectOfType<GameManager>().NextLevel03();
        }
        if (collisionInfo.collider.tag == "LivePower")
        {
            Destroy(collisionInfo.gameObject);
            FindObjectOfType<GameManager>().AddLives();            
        }
        if (collisionInfo.collider.tag == "SlowPower")
        {
            Destroy(collisionInfo.gameObject);
            FindObjectOfType<mom>().Slow();
        }


    }
    public void LastLive()
    {
        Debug.Log("reeee");
        movement.enabled = false;
    }
    
}
