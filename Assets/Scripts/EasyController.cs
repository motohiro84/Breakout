using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

        Transform BarTrans = GameObject.Find("Player").transform;
        Vector3 pos = BarTrans.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (pos.z < 3.8)
            {
                this.transform.Translate(0f, 0f, 0.1f);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (pos.z > -3.8)
            {
                this.transform.Translate(0f, 0f, -0.1f);
            }
        }
    }
}
