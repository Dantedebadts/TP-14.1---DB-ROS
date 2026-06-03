using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerC : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public float tiempo = 60f;
    public bool corriendo = true;

    void Start()
    {
        int segundos = Mathf.FloorToInt(tiempo);
        Timer.text = segundos.ToString("00");
    }

    void Update()
    {
        if (corriendo)
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
            }
        }
    }
}