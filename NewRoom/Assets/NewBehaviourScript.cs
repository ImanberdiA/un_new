using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera camera;
    [SerializeField] private GameObject _explosing;
    private GameObject explosing;
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                  explosing = Instantiate(_explosing) as GameObject; 
                
                explosing.transform.position = hit.point;
                Destroy(this.gameObject);
               // Debug.Log("hit" + objectHit.position.x.ToString());
                
            }
        }

    }
    /*
       if (Input.GetMouseButton(0))
        {
            Ray ray = new Ray(transform.position, transform.forward * 100f+transform.up);
            RaycastHit hit;
            Debug.Log("hit1");
            
            if(Physics.Raycast(ray,out hit))
            {
              //   Debug.Log("hit2",hit.point.x);
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                 sphere.transform.position = hit.point;
                 Debug.Log(hit.point);
            }
        }
    */
}