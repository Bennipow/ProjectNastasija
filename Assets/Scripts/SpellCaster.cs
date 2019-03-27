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
    ECastType m_Type;

    void Start()
    {
        
    }

    void Update()
    {
        //statemachine
        switch (m_CastState)
        {
            case ECastState.WaitForSpellCreate:
                if (Input.GetKeyUp(KeyCode.Space))
                {
                    m_CastState = ECastState.WaitForSize;
                }
                break;
            case ECastState.WaitForSize:
                if (Input.GetKeyUp(KeyCode.S))
                {
                    m_Size = 1;
                }
                else if (Input.GetKeyUp(KeyCode.M))
                {
                    m_Size = 2;
                }
                else if (Input.GetKeyUp(KeyCode.L))
                {
                    m_Size = 3;
                }
                else
                {
                    break;
                }
                m_CastState = ECastState.WaitForElement;
                break;
            case ECastState.WaitForElement:
                if (Input.GetKeyUp(KeyCode.E))
                {
                    m_Element = ESpellType.Earth;
                }
                else if (Input.GetKeyUp(KeyCode.F))
                {
                    m_Element = ESpellType.Fire;
                }
                else if (Input.GetKeyUp(KeyCode.I))
                {
                    m_Element = ESpellType.Ice;
                }
                else
                {
                    break;
                }
                m_CastState = ECastState.WaitForCastType;
                break;                
            case ECastState.WaitForCastType:
                if (Input.GetKeyUp(KeyCode.B))
                {
                    m_Type = ECastType.Ball;
                }
                else if (Input.GetKeyUp(KeyCode.L))
                {
                    m_Type = ECastType.Lance;
                }
                else if (Input.GetKeyUp(KeyCode.C))
                {
                    m_Type = ECastType.CircleGround;
                }
                else
                {
                    break;
                }
                CreateSpell();
                m_CastState = ECastState.WaitForSpellCreate;
                break;
            default:
                break;
        }
    }

    void CreateSpell()
    {
        Spell spell = new Spell(m_Size, m_Element, m_Type);
        spell.CastSpell();
    }
}
