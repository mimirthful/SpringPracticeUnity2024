using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki {
public class InputReader : MonoBehaviour
{
    // Alkuarvot kirjoitettuna auki.
    private Inputs _inputs = null;

    private Vector2 _movementInput = Vector2.zero;

    private bool _interactInput = false;

    // c# Propertyt korvaavat mm. javan getterit ja setterit.
    // Property näyttää käyttäjälle muuttujslys, mutta se käyttäytyy kuin get ja set metodit
    // Tällä propertyllä on getteri, joka palauttaa movement arvon. Sitä voidaan lukea niinkuin muuttujan arvoa.
    public Vector2 Movement
    {
        get { return _movementInput; }
    }
    
    // Awake voidaan käyttää komponenttien alustamiseen, korvaa olion alustamiseen.
    private void Awake()
    {
        // Alustetaan inputs-olio Awakessa luomalla new;llä uusi Inputs-olio.
        _inputs = new Inputs();

    }
    // Suoritetaan Awaken jälkeen joka kerta kun enabloidaan.
    private void OnEnable()
    {
        //Aktivoidaan input OnENablessa eli kun objecti aktivoidaan.
        _inputs.Game.Enable();
    }
    
    
    private void OnDisable()
    {
        // Deaktivoidaan kun objekti deaktivoituu.
        _inputs.Game.Disable();
    }

    // Luetaan inputin arvo jokaisella framella.
    private void Update()
    {
        _movementInput = _inputs.Game.Move.ReadValue<Vector2>();
        
        //TODO: lue interaktio inputin arvo (eventti)

    }

    
}
}
