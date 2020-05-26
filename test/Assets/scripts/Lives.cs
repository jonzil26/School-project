
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text livesText;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
       livesText.text= ("Lives:  " + FindObjectOfType<GameManager>().lives);

    }
}
