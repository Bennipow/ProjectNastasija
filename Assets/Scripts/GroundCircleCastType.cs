using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCircleCastType : CastType
{
    public override void CollisionWithSomething()
    {
        throw new System.NotImplementedException();
    }

    public override void FixedUpdateAfterCasting()
    {
        throw new System.NotImplementedException();
    }

    public override void FixedUpdateWhileCasting()
    {
        //check for input
        // Check if the indicator hitssomething
        // when both are fine then cast spell 
    }

    public override void UpdateAfterCasting()
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateWhileCasting()
    {
        throw new System.NotImplementedException();
    }

    public void WhileCastingFixedUpdate()
    {
        // make the indicator on the ground which is a raycast from the controller
    }
}
