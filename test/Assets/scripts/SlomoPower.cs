
using UnityEngine;

public class SlomoPower : MonoBehaviour
{
    public float RegularTime = 1f;
    public float MinTime = 0.3f;
    public float SlowFector = 0.05f;
    public bool Slomo = false;
    // Start is called before the first frame update
    void Start()
    {

    }
   public void DoSlow()
    { 
    if (Time.timeScale<MinTime)
        {
            Slomo = true;
        }

        if (Slomo == false)
        {
            Time.timeScale =MinTime;
            Time.fixedDeltaTime = Time.timeScale* 0.02f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Time.timeScale += (1f / 2f) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);

    }
}
