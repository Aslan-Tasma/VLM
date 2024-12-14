using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorRayCast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string exludeLayerName = null;

    private MyDoorController reycastObj;
}
