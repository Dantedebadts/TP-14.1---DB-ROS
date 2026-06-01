using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class recogerObjeto : MonoBehaviour
{
    public int paquetescoleccionados = 0;
    public TextMeshProUGUI paquetestxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.CompareTag("paquete")) {
            Destroy(col.gameObject);
            paquetescoleccionados++;
            paquetestxt.text = "Paquetes coleccionados: " + paquetescoleccionados;
        }
    }
}
