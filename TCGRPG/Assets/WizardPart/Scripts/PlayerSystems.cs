using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerSystems : MonoBehaviour
{
    protected Player playerID;
    protected virtual void Start()
    {
        playerID = gameObject.GetComponent<PlayerBuild>().player;
    }
}
