
using UnityEngine;

public class spin : MonoBehaviour
{
    public Rigidbody sp;
    public float x = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sp.transform.Rotate(x, 0, 0);
    }
}
