using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_combat : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer player_color;

    public Transform attack_point;
    public float attack_range = 0.5f;
    public LayerMask enemyLayer;

    public GameObject ultimate;
    public bool IsUltimateUp;
    public player_bars ultimateIcon;

    void Start()
    {
        player_color = GetComponent<SpriteRenderer>();

        IsUltimateUp = false;
        ultimateIcon.enabled = false;
    }

    void Update()
    {
        ChargeUltimate();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsUltimateUp == true)
            {
                Instantiate(ultimate, new Vector2((this.transform.position.x + 0.5f), (this.transform.position.y + 0.5f)), Quaternion.identity);
                IsUltimateUp = false;
                ultimateIcon.enabled = false;
            }
            
            attack();
        }
    }

    public void attack()
    {
        //play anim
        animator.SetFloat("speed", 0f);
        animator.SetTrigger("attack");
        //detect enemy
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attack_point.position, attack_range, enemyLayer);
        //damage them
        foreach(Collider2D enemy in enemies)
        {
            Debug.Log("We Hit " + enemy.name);
        }
    }

    private void ChargeUltimate()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            //audio weapon change 
            //weapon change
            IsUltimateUp = true;
            ultimateIcon.enabled = true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attack_point == null)
            return;

        Gizmos.DrawWireSphere(attack_point.position, attack_range);
    }
}
