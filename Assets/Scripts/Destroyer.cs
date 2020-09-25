using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{


    public GameObject masterObj;
    
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Hard")
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        masterObj.GetComponent<GameMaster>().boxNum--;
        Destroy(gameObject);
    }
}
