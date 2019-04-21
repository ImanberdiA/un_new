using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatl : MonoBehaviour
{
    public Material[] mater;
    Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k")) {
            Application.LoadLevel("SampleScene");
        }
    }

    void OnMouseDown()
    {
        Debug.Log(gameObject.name);

        render = gameObject.GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = mater[0];

    }
}
