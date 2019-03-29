using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellObject : MonoBehaviour
{
    // Collider for Spell hit detection
    Collider m_MyCollider;
    // Particle System for Type of Spell
    ParticleSystem m_MyParticleSystem;
    // Particles for spell element
    Sprite m_ParticleSprite;
    // Spell with stats
    Spell m_MySpell;
}
