using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Hallinnoi pelihahmoa. riippuvuudet Inputreader ja Mover
    /// </summary>
    [RequireComponent(typeof(InputReader), typeof(Mover))]
    public class PlayerController : MonoBehaviour
    {
        private InputReader _inputReader = null;

        private Mover _mover = null;

        private void Awake()
        {
            // Alustetaan InputReader ja Mover Awake-metodissa.
            _inputReader = GetComponent<InputReader>();
            _mover = GetComponent<Mover>();
        }

        // Update is called once per frame
        private void Update()
        {
            // Luetaan käyttäjän syöte
            Vector2 movement = _inputReader.Movement;
            _mover.Move(movement);
        }
    }
}