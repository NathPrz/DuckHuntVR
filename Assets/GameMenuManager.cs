using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.XR.CoreUtils;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField]
    public GameObject menu;
    [SerializeField]
    public Transform head;

    [SerializeField]
    public float spawnDistance = 2;
    public InputActionProperty showButton;
    // Start is called before the first frame update
    public void showMenu()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            Debug.Log(menu.activeSelf);
            if (menu.activeSelf)
            {
                menu.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
            }
            
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;

        }
        menu.transform.LookAt(new Vector3(head.position.x, head.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }
}
