using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CastType
{
    public abstract void UpdateWhileCasting();

    /// <summary>
    /// A method which is Called when the Spell is created and the Player has to cast it
    /// Example: Lance spells lance is in hand and player can throw it
    /// Example: Indicator for ground ability is shown
    /// </summary>
    public virtual void StartWhenStartedCasting() { }
}
