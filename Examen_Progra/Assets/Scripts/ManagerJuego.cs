using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerJuego : MonoBehaviour
{
    public static ManagerJuego instancia;
    public int puntaje;
    public TextMeshProUGUI texto;
    public void Awake()
    {
        instancia = this;
    }
    public static ManagerJuego ObtenerInstancia()
    {
        return instancia;
    }
    public void Puntaje(int contador)
    {
        puntaje += contador;
        PuntajeUI();
    }
    public void PuntajeUI()
    {
        texto.text = "Puntaje:  "+ puntaje.ToString("");
    }
}
