using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardGame/CardFunctions")]
public class CardFunctions : ScriptableObject
{
    public static void GoFirst()
    {
        Debug.Log("this should be first");
    }
    public static void GoSecond()
    {
        Debug.Log("this should be second");
    }
    public static void GoThird()
    {
        Debug.Log("this should be third");
    }
    public static void SendToDiscard()
    {
        //I think you'll get this one
    }

    public static void SendToHand()
    {
        //This one too
    }

    public static void ReturnToDeck()
    {
        //This one as well
    }

    public static void ShuffleDeck()
    {
        //I think I can stop now
    }

    public static void ChooseTargets()
    {
        //This one will be used to tell the game which targets to ue an ability on
    }

    public static void TargetAttacker()
    {
        //For hurt and death effects, will set the target to the attacker
    }
    public static void PoisonCard()
    {
        //does nothing rn
    }


}
