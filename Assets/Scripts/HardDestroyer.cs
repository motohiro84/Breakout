using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardDestroyer : MonoBehaviour
{

    public int HP = 2;
    public GameObject masterObj;
    [ColorUsage(false, true, 0f, 8f, 0.125f, 3f)]
    public Color coloring;
    private MeshRenderer r;
    
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

    private void OnCollisionEnter(Collision collision)
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
}
