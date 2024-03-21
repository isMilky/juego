using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonJugar : MonoBehaviour
{
    public void OnclickJugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel1");
        Debug.Log("Click");
    }
}
