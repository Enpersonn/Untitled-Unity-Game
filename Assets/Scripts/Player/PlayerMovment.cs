using UnityEngine;

namespace Player
{
    public class PlayerMovment : MonoBehaviour
    {
        public float speed = 200f;
        Vector2 move;
        Rigidbody2D rb;


        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            rb.velocity = move * (speed * Time.deltaTime);
        }

        void Update()
        {
            move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }
}

