
using UnityEngine;

public class mom : MonoBehaviour
{
    public Rigidbody rb;
    public float kadima ;
    public float up;
    public float jump;
    // Start is called before the first frame update

    //public void Jump ()
        //{
        //     up = 0;
        //}
// Update is called once per frame
public void Slow()
    {
        up = 10;
        jump = 650;
        kadima = 25;
    }
void Update()
    {
      rb. AddForce(up, 0, 0);
        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(kadima * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(-kadima * Time.deltaTime, 0, 0);
        //}
        if (Input.GetKey("w"))
        {
            rb.AddForce(30, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -kadima * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, kadima * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, jump, 0);
            //    //while (collisionInfo.collider.name!="ground")
            //    //{
            //    //    movement.up = 0;
            //    //}
            }
        if (Input.GetKeyDown("r"))
        {
            FindObjectOfType<GameManager>().Restart();
        }
        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
         
    }
}
