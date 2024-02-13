using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Mobiiliesimerkki
{
    /// <summary>
    /// Hallinnoi pelihahmoa. riippuvuudet Inputreader ja Mover
    /// </summary>
    [RequireComponent(typeof(InputReader))]
    public class PlayerController : MonoBehaviour
    {
        // Vakiot, näiden arvoa ei voi muuttaa ajon aikana.
        private const string SpeedAnimationParameter = "Speed";
        private const string DirectionXParameter = "DirectionX";
        private const string DirectionYParameter = "DirectionY";
        //--
        private Animator _animator = null;
        
        private InputReader _inputReader = null;

        private IMover _mover = null;
        private SpriteRenderer _spriteRenderer = null;

        private void Awake()
        {
            // Alustetaan InputReader ja Mover Awake-metodissa.
            _inputReader = GetComponent<InputReader>();
            _mover = GetComponent<IMover>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();

        } 

        // Update is called once per frame
        private void Update()
        {
            // Luetaan käyttäjän syöte
            Vector2 movement = _inputReader.Movement;
            _mover.Move(movement);
            UpdateAnimator(movement);
            
        }

        private void UpdateAnimator(Vector2 movement)
        {
            _animator.SetFloat(DirectionXParameter, movement.x);
            _animator.SetFloat(DirectionYParameter, movement.y);
            _animator.SetFloat(SpeedAnimationParameter, movement.sqrMagnitude);

            bool lookRight = movement.x > 0;
            _spriteRenderer.flipX = lookRight;
        }
    }
}