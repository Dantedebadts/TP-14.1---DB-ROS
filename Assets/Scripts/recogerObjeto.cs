using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogerObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        Debug.Log(gameObject.name + " colisionaste con " + col.gameObject.name);
        if(col.gameObject.CompareTag("paquete")) {
            Destroy(col.gameObject);
        }
    }
}
