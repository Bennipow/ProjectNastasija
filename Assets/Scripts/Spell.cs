using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ESpellType
{
    Fire,
    Ice,
    Earth,
}

public enum ECastType
{
    Ball,
    Lance,
    CircleGround,
}

public class Spell
{
    public readonly ESpellType m_SpellType;
    public readonly ECastType m_CastType;
    public readonly int m_Size;

    public float m_SpellDamage;
    public float m_ManaCost;    

    public Spell(int _size, ESpellType _spelltype, ECastType _casttype)
    {
        m_SpellType = _spelltype;
        m_CastType = _casttype;

    }

    public void CastSpell()
    {
        CreateSpellStats();
        Debug.Log(m_SpellType + "" + m_CastType);
    }

    /// <summary>
    /// Create the Spell Stats from its element size and spell type
    /// </summary>
    private void CreateSpellStats()
    {
        switch (m_CastType)
        {
            case ECastType.Ball:
                m_SpellDamage = m_Size * 10 + 30;
                m_ManaCost = m_Size * 10 + 10;
                break;
            case ECastType.Lance:
                m_SpellDamage = m_Size * 10 + 50; 
                m_ManaCost = m_Size * 10 + 20;
                break;
            case ECastType.CircleGround:
                m_SpellDamage = 50 - m_Size * 2; 
                m_ManaCost = m_Size * 10 + 10;
                break;
            default:
                break;
        }
    }    
}