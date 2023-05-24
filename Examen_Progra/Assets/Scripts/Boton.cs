using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Boton : BotonAbstracto
{
    public UnityAction<int> Accion;
    public int incrementarpuntaje;
    public override void AccionBoton()
    {
        ManagerJuego.instancia.Puntaje(incrementarpuntaje);
        Accion?.Invoke(incrementarpuntaje);
    }

}
