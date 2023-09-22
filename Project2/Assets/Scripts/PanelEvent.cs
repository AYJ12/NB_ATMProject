using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelEvent : MonoBehaviour
{
    public void OnClickEvent()
    {
        Destroy(gameObject);
    }
}
