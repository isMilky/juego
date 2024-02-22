using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonInst : MonoBehaviour
{
    public void OnclickInst()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
        Debug.Log("Instrucciones");
    }
}
