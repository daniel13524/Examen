using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntajeObserver : MonoBehaviour
{
    void Start()
    {
        ManagerJuego.instancia.Puntaje(0);
    }
}
