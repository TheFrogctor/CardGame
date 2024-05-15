using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamiliarCardScript : MonoBehaviour
{
    [SerializeField] FamiliarCardData cardData;
    public List<GameObject> targets = new List<GameObject>(); //Constantly changing variable to tell the card what to target for abilities
    [SerializeField] public List<object> statusEffects = new List<object>(); //List of status effects, evens (including 0) are the effects, the following odds are the numbers associated with the effects
}
