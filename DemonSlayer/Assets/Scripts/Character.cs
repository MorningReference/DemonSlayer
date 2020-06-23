using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    [SerializeField] string Name;
    [SerializeField] int Strength;
    [SerializeField] int Stamina;
    [SerializeField] int Endurance;
    [SerializeField] int Dexterity;
    [SerializeField] int Agility;
    [SerializeField] int Luck;
    [SerializeField] int CurrentHP;
    [SerializeField] int MaxHP;
    [SerializeField] int CurrentBreathCapacity;
    [SerializeField] int MaxBreathCapacity;
    [SerializeField] int CurrentTensionMeter;
    [SerializeField] float Attack;
    [SerializeField] float Defense;
    [SerializeField] float AttackSpeed;
    [SerializeField] float CriticalRate;
    [SerializeField] float CriticalDamage;

}
