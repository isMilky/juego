using System.Collections;
using MoreMountains.Tools;
using System.Collections.Generic;
using UnityEngine;

public class BotonRegresar : MonoBehaviour
{
    public void OnclickReturn()
    {
        MMSceneLoadingManager.LoadScene("Inicio");
        Debug.Log("Regresaste, yay!");
    }
}
