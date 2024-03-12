using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejaMonedas : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private int Monedas_recolectadas()
    { }
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    } 
    public virtual void onMMEvent(PickableItemEvent pickableitemevent)
    {

    }
}
        


   

}
