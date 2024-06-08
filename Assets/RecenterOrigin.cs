using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.XR.CoreUtils;

public class RecenterOrigin : MonoBehaviour
{
    [SerializeField]
    public Transform head;
    [SerializeField]
    public Transform origin;
    [SerializeField]
    public Transform target; 
    public InputActionProperty recenterButton;

    public void Recenter()
    {
        /*        XROrigin xrOrigin = GetComponent<XROrigin>();
                xrOrigin.MoveCameraToWorldLocation(target.position);
                xrOrigin.MatchOriginUpCameraForward(target.up, target.forward);*/

        Vector3 offset = head.position - origin.position;
        origin.position = target.position - offset;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (recenterButton.action.WasPressedThisFrame())
        {
            Recenter();
        }
    }
}
