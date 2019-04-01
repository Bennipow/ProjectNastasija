using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CastType
{
    public abstract void FixedUpdateWhileCasting();
    public abstract void UpdateWhileCasting();

    /// <summary>
    /// Method which is called in the fixedupdate after being casted for example Movement
    /// </summary>
    public abstract void FixedUpdateAfterCasting();

    public abstract void UpdateAfterCasting();

    /// <summary>
    /// A method which is Called when the Spell is created and the Player has to cast it
    /// Example: Lance spells lance is in hand and player can throw it
    /// Example: Indicator for ground ability is shown
    /// </summary>
    public virtual void StartWhenStartedCasting() { }

    public abstract void CollisionWithSomething();
}
