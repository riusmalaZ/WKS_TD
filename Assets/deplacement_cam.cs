using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement_cam : MonoBehaviour
{
    public Transform LimitMin, LimitMax;

    [SerializeField]
    Vector3 direction;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(0, 0, -Input.GetAxis("Horizontal")) * speed * Time.deltaTime;
        transform.position += direction ;
        //transform.position = Vector3.Min(LimitMax.position, Vector3.Max(LimitMin.position, transform.position));
    }
}
