using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{


    public GameObject masterObj;
    [ColorUsage(false, true, 0f, 8f, 0.125f, 3f)]
    public Color coloring;
    private MeshRenderer r;
    private int HP = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<MeshRenderer>();
        r.material.EnableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ball"))
        {
            masterObj.GetComponent<GameMaster>().boxNum--;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Level.mode == 3)
        {
            HP--;
            if ( HP == 1 )
            {
                r.material.SetColor("_EmissionColor", coloring);
            }
            else if ( HP == 0 )
            {
                masterObj.GetComponent<GameMaster>().boxNum--;
                Destroy(gameObject);
            }
        }
        else
        {
            masterObj.GetComponent<GameMaster>().boxNum--;
            Destroy(gameObject);
        }
    }
}
