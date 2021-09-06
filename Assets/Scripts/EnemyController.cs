using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;
    public float speed = 5;
    private float x;
    private float y;
    Vector2 dir;
    public void Start()
    {
        x = Target.transform.position.x - gameObject.transform.position.x;
        y = Target.transform.position.y - gameObject.transform.position.y;
        dir = new Vector2(x, y);
    }

    private void Update()
    {
        gameObject.transform.Translate((dir.normalized) * speed * Time.deltaTime);
    }
    public void SwitchTarget(GameObject point)
    {
        Target = point;
        Start();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MainBuilding"))
        {
            Destroy(gameObject);
            collision.GetComponent<MainBuildCont>().Damage(10);
        }
        if (collision.CompareTag("Target"))
        { 
            SwitchTarget(collision.GetComponent<TargetControler>().Target);
        }
    }
}
