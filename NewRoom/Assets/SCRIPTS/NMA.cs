using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NMA : MonoBehaviour
{
    public GameObject agent_object;
    private UnityEngine.AI.NavMeshAgent agent;
    public GameObject check_point_1, check_point_2;
    private Transform target;
    private float time = 5.0f;
    private bool change_code = false;
    public GameObject Panel;
    
    void Start()
    {
        agent = agent_object.GetComponent<UnityEngine.AI.NavMeshAgent>();
        // check_point = GameObject.FindWithTag("Player");
        target = check_point_1.transform;
    }

    void Update()
    {
        agent.SetDestination(target.position);
        if (change_code) {
            time -= Time.deltaTime;
            if (time < 0) {
                Panel.SetActive(false);
                target = check_point_2.transform;
                change_code = false;
            }
            //Panel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("We are in trigger");
        change_code = true;
        Panel.SetActive(true);
    }
}
