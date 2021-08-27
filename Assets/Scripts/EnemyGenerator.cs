using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject building;
    [SerializeField]
    public GameObject Enemy;
    [SerializeField]
    public Transform[] points;
    public GameObject[] firstTarget;
    public float cdtime;
    public float curSpeed;
    public int mk;
    public int curk=0;
    private void Start()
    {
        Gen();
    }

    void Gen()
    {
        if(curk <= mk)
        {
            int num = Random.Range(0, points.Length);
            curk++;
            GameObject en = Instantiate(Enemy, points[num].position, Quaternion.identity);
            en.GetComponent<EnemyController>().Target = firstTarget[num];
            en.GetComponent<EnemyController>().speed = curSpeed;
            StartCoroutine(CD());
        }
    }
    IEnumerator CD()
    {
        yield return new WaitForSeconds(cdtime);
        Gen();
    }
}
