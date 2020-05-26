
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public float Delay = 2f;
   public float lives=3;

    public void AddLives()
    {
        lives = lives + 1;
    }

    public void EndGame ()
        
    {
        lives = lives - 1;
        
        if (lives >0)
        {
           
            
            Debug.Log("- 1 live");

        }
        else
        {
            FindObjectOfType<PlayerCollision>().LastLive();

            Invoke("Restart", Delay);

        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
    public void NextLevel02()
    {
        SceneManager.LoadScene("Level02");
        
    }
    public void NextLevel03()
    {
        SceneManager.LoadScene("Level03");

    }
}