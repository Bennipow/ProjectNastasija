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

    public Spell(int _size, ESpellType _spelltype, ECastType _casttype)
    {
        m_SpellType = _spelltype;
        m_CastType = _casttype;
    }

    public void CastSpell()
    {
        Debug.Log(m_SpellType + "" + m_CastType);
    }
}
