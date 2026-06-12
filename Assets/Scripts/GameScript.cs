using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public int paquetescoleccionados = 0;
    public TextMeshProUGUI paquetestxt;
    public GameObject PantallaGanaste;
    public TextMeshProUGUI Timer;
    public float tiempo = 60f;
    private bool corriendo = true;
    public GameObject PantallaGameOver;
    // Start is called before the first frame update
    void Start()
    {
        int segundos = Mathf.FloorToInt(tiempo);
        Timer.text = segundos.ToString("00");
        PantallaGameOver.SetActive(false);
        PantallaGanaste.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(corriendo);
        if (corriendo == true)
        {
            if (tiempo > 0)
            {
                tiempo -= Time.deltaTime;
                int segundos = Mathf.FloorToInt(tiempo);
                Timer.text = segundos.ToString("00");
            }
            else
            {
                tiempo = 0;
                corriendo = false;
                Timer.text = "00";
                PantallaGameOver.SetActive(true);
            }
        }
        
    }
     void OnTriggerEnter(Collider col) {
        if(col.gameObject.CompareTag("paquete")) {
            Destroy(col.gameObject);
            paquetescoleccionados++;
            paquetestxt.text = "Paquetes coleccionados: " + paquetescoleccionados;
            if(paquetescoleccionados >= 5){
                corriendo = false;
                PantallaGanaste.SetActive(true);
            }
        }
    }
    public void ReiniciarJuego()
    {
        string nombreEscenaActual = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nombreEscenaActual);
    }
}
