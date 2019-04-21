using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Raycast : MonoBehaviour
{
    public Material[] mater;
    Renderer render;

    public Camera fpsCam;
    public float range = 100f;

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;
            GetRayName();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                CallMenu();
            }
            else {
                CancelMenu();
            }
        }

    }

    void GetRayName()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);

            if (hit.transform.name == "hotl_interior")
            {
                CallMenu();
            }
            


            //ButtonHandlerChangeMaterial();

        }
    }


    public void ButtonHandlerChangeMaterial(int i)
    {
        Debug.Log(hit.transform.name);
        render = hit.transform.GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = mater[i];
        CancelMenu();
    }



    void CancelMenu()
    {
        PauseMenuUI.SetActive(false);
    }

    void CallMenu()
    {
        PauseMenuUI.SetActive(true);
    }


}
