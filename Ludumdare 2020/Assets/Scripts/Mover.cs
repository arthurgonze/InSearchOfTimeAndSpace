using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Adventure.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _velocidadeDeMovimento = 1.5f;

        private float movimentoHorizontal;
        private float movimentoVertical;
        float moveLimiter = 0.7f;

        // Cached References
        private Rigidbody2D _rigidbody2D;

        // Start is called before the first frame update
        void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            //Store the current horizontal input in the float moveHorizontal.
            movimentoHorizontal = Input.GetAxis("Horizontal");

            //Store the current vertical input in the float moveVertical.
            movimentoVertical = Input.GetAxis("Vertical");
        }
        // Update is called once per frame
        void FixedUpdate()
        {
            PlayerInput();
        }

        private void PlayerInput()
        {
            if (movimentoHorizontal != 0 && movimentoVertical != 0) // Check for diagonal movement
            {
                // limit movement speed diagonally, so you move at 70% speed
                movimentoHorizontal *= moveLimiter;
                movimentoVertical *= moveLimiter;
            }

            transform.position = new Vector2(transform.position.x + movimentoHorizontal * _velocidadeDeMovimento * Time.deltaTime, transform.position.y + movimentoVertical * _velocidadeDeMovimento * Time.deltaTime);
        }
    }

}
