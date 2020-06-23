using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy _enemy = other.GetComponent<Enemy>();
        if (_enemy != null)
        {
            _enemy.TakeDamage(GetComponentInParent<PlayerAttack>().damage);
        }
    }
}
