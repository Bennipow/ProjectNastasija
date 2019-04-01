using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCastType : CastType
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
        //Check for Input 
        // When player decided to shoot the fireball shoot the fireball in the direction the player points
    }

    public override void UpdateAfterCasting()
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateWhileCasting()
    {
        throw new System.NotImplementedException();
    }
}
