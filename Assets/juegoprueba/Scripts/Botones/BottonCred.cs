using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonCred : MonoBehaviour
{
    public void OnclickCred()
    {
        MMSceneLoadingManager.LoadScene("Credits");
        Debug.Log("Creditos");
    }
}
