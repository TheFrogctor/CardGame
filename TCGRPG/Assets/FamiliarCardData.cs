using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "CardGame/FamiliarCard")]
public class FamiliarCardData : CardData
{
    public string Domain;
    public int Attack;
    public int Defense;
    public string description;

    public UnityEvent OnDestroy;
    public UnityEvent OnPlay;
    public UnityEvent ActivateAbility;
}
