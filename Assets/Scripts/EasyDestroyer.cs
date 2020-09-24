using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyDestroyer : MonoBehaviour
{

    public GameObject masterObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
}
