using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamiliarCardScript : MonoBehaviour
{
    [SerializeField] FamiliarCardData cardData;
    [HideInInspector] public List<GameObject> targets = new List<GameObject>(); //Constantly changing variable to tell the card what to target for abilities
    
}
