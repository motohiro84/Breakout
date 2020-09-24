using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
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
            if(SceneManager.GetActiveScene().name != "Easy")
            {
                if (pos.z < 4)
                {
                    this.transform.Translate(0f, 0f, 0.1f);
                }
            }
            else if(SceneManager.GetActiveScene().name == "Easy")
            {
                if (pos.z < 3.7)
                {
                    this.transform.Translate(0f, 0f, 0.1f);
                }
            }
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if(SceneManager.GetActiveScene().name != "Easy")
            {
                if (pos.z > -4)
                {
                    this.transform.Translate(0f, 0f, -0.1f);
                }
            }
            else if(SceneManager.GetActiveScene().name == "Easy")
            {
                if (pos.z > -3.7)
                {
                    this.transform.Translate(0f, 0f, -0.1f);
                }
            }
        }
    }
}
