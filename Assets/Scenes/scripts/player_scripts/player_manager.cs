using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{
    public int Health = 100;
    public int current_health;

    public int Mana = 3;
    public int current_mana;

    public player_bars healthBar;
    public player_bars manaBar;

    void Start()
    {
        current_health = Health;
        current_mana = Mana;

        healthBar.max_health(Health);
        manaBar.max_mana(Mana);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            Take_Damage(20);

        if (Input.GetKeyDown(KeyCode.K))
            Use_Ultimate(1);
    }

    public void Take_Damage(int damage)
    {
        current_health -= damage;
        healthBar.set_health(current_health);
    }

    public void Use_Ultimate(int mana_cost)
    {
        current_mana -= mana_cost;
        manaBar.set_mana(current_mana);
    }
}
