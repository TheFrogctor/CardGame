using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardGame/Card")]
public class Card : ScriptableObject
{
    public string CardName;
    public string Domain;
    public int Cost;
    public string CardType;
    public int Attack;
    public int Defense;
    public string Ability;
    public Sprite cardart;
}
