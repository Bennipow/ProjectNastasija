using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpellCaster : MonoBehaviour
{
    enum ECastState
    {
        WaitForSpellCreate,
        WaitForSize,
        WaitForElement,
        WaitForCastType,
    }

    ECastState m_CastState = ECastState.WaitForSpellCreate;

    int m_Size = 0;
    ESpellType m_Element;
    CastType m_Type;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void CreateSpell()
    {
        Spell spell = new Spell(m_Size, m_Element, m_Type);
        spell.CastSpell();
    }
}
