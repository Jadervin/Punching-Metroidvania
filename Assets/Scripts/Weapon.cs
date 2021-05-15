using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;
    public string shootingTrigger;

    public Transform firePoint;
    public GameObject fistPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Attack"))
        {
            animator.SetTrigger(shootingTrigger);
            Attack();
        }
    }


    void Attack()
    {
        Instantiate(fistPrefab, firePoint.position, firePoint.rotation);
    }
}
