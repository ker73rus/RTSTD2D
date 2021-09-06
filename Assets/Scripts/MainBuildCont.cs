using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBuildCont : MonoBehaviour
{
    [SerializeField]
    private Image hp;
    public float maxhealth;
    public float health;
    void Start()
    {
        health = maxhealth;
    }
    private void Update()
    {
        
    }
    public void Damage(int damage)
    {
        health -= damage;
        hp.fillAmount = health / maxhealth;
    }
}
