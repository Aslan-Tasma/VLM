using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorRayCast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string exludeLayerName = null;

    private MyDoorController reycastObj;

    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

  
    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObject";

    private void Update()
    {
       RaycastHit hit;
       Vector3 fwd = transform.TransformDirection(Vector3.forward);
       int mask = 1 << LayerMask.NameToLayer(exludeLayerName) | layerMaskInteract.value;
       if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
       {
            if(hit.collider.CompareTag(interactableTag))
            {
                if(!doOnce)
                {
                    reycastObj = hit.collider.gameObject.GetComponent<MyDoorController>();
                }
            }
            doOnce = true;

            if (Input.GetKeyDown(openDoorKey))
            {
                reycastObj.PlayAnimation();
            }
       }
    }
}
