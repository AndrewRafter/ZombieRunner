using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public bool IsDead() { 
        return isDead; 
    }

    //public method to reduce hitpoints by amount of dmg(from weapon)
    public void TakeDamage(float damage) {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if(hitPoints <= 0) {
            Die();
        }
    }


    void Die() {
        if(isDead) { return; }
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
