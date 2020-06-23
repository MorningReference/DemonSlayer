using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRangeX;
    public float attackRangeY;
    public float attackRangeAngle = 0;
    public int damage;

    public GameObject hitBox;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && timeBtwAttack <= 0)
        {
            Attack();
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
    // void OnDrawGizmosSelected()
    // {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireCube(attackPos.position, new Vector3(attackRangeX, attackRangeY, 0));
    // }

    void Attack()
    {
        // if (timeBtwAttack <= 0)
        // {
        GetComponent<Animator>().SetTrigger("Attack");
        // GetComponent<Animator>().SetBool("Attacking", true);
        // Debug.Log("We attacked");




        // void OnCollisionEnter2D(Collision2D _colInfo)
        // {
        //     Enemy _enemy = _colInfo.collider.GetComponent<Enemy>();
        //     if (_enemy != null)
        //     {
        //         _enemy.TakeDamage(damage);
        //     }
        // }

        // Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos.position, new Vector2(attackRangeX, attackRangeY), attackRangeAngle, whatIsEnemies);
        // for (int i = 0; i < enemiesToDamage.Length; i++)
        // {
        //     enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
        // }
        // GetComponent<Animator>().SetBool("Attacking", false);
        // GetComponent<Animator>().SetTrigger("Attack");


        // }
        // else
        // {
        //     timeBtwAttack -= Time.deltaTime;
        // }
    }

}