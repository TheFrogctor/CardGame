using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamiliarCardScript : MonoBehaviour
{
    [SerializeField] FamiliarCardData cardData;
    [HideInInspector] public List<GameObject> targets = new List<GameObject>(); //Constantly changing variable to tell the card what to target for abilities
    public List<object> statusEffects = new List<object>(); //List of status effects, evens (including 0) are the effects, the following odds are the numbers associated with the effects

    void Awake()
    {
        cardData.OnPlay.Invoke(gameObject);
    }
}
