using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    private SphereCollider bar1;
    private SphereCollider bar2;

    void Start()
    {
        bar1 = this.gameObject.AddComponent<SphereCollider>();
        bar2 = this.gameObject.AddComponent<SphereCollider>();
        bar1.center = new Vector3(0f, 0f, 0.5f);
        bar2.center = new Vector3(0f, 0f, -0.5f);

        if (Level.mode == 1)
        {
            this.transform.localScale = new Vector3(0.4f, 0.6f, 2.5f);
            bar1.radius = 0.15f;
            bar2.radius = 0.15f;
        }
        else
        {
            bar1.radius = 0.25f;
            bar2.radius = 0.25f;
        }
    }

    // Update is called once per frame
    void Update(){

        Transform BarTrans = GameObject.Find("Player").transform;
        Vector3 pos = BarTrans.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(Level.mode == 1)
            {
                if (pos.z < 3.7)
                {
                    this.transform.Translate(0f, 0f, 0.1f);
                }
            }
            else
            {
                if (pos.z < 4)
                {
                    this.transform.Translate(0f, 0f, 0.1f);
                }
            }
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if(Level.mode == 1)
            {
                if (pos.z > -3.7)
                {
                    this.transform.Translate(0f, 0f, -0.1f);
                }
            }
            else
            {
                if (pos.z > -4)
                {
                    this.transform.Translate(0f, 0f, -0.1f);
                }
            }
        }
    }
}
