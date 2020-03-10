using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_bars : MonoBehaviour
{
    public Slider health_slider;
    public Gradient health_gradient;
    public Image health_fill;

    public Slider mana_slider;
    public Gradient mana_gradient;
    public Image mana_fill;

    public Image ultimate_icon;

    public void max_health(int health)
    {
        health_slider.maxValue = health;
        health_slider.value = health;

        health_fill.color = health_gradient.Evaluate(1f);
    }

    public void set_health(int health)
    {
        health_slider.value = health;

        health_fill.color = health_gradient.Evaluate(health_slider.normalizedValue);
    }

    public void max_mana(int mana)
    {
        mana_slider.maxValue = mana;
        mana_slider.value = mana;

        mana_fill.color = mana_gradient.Evaluate(1f);
    }

    public void set_mana(int mana)
    {
        mana_slider.value = mana;

        mana_fill.color = mana_gradient.Evaluate(mana_slider.normalizedValue);
    }
}
