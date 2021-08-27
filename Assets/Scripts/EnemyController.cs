using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;
    public float speed = 5;
    private float x;
    private float z;
    Vector3 vec;
    public void Start()
    {
        //gameObject.transform.LookAt(Target.transform);
        gameObject.transform.Rotate(new Vector3(0, 0, 0));
    }

    private void Update()
    {
        gameObject.transform.Translate((Vector3.forward) * speed * Time.deltaTime);
    }
    public void SwitchTarget(GameObject point)
    {
        Target = point;
        Start();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainBuilding"))
        {
           
        }
        if (other.CompareTag("Target"))
        {
           
        }
    }
}
