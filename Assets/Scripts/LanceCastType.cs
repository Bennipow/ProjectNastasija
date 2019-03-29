using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanceCastType : CastType
{
    public override void UpdateWhileCasting()
    {
        //Check for input
        // when the player used the input to throw the lance
        //              check for the velocity of the controller and use it for the lance (no gravity)
    }

    public override void StartWhenStartedCasting()
    {
        //Instantiate the lance in the Playerhand
    }
}
