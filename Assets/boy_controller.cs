 using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Security.Cryptography;
    using System.Threading;
    using UnityEngine;
    using UnityEngine.UI;

    public class Idle_Controller : MonoBehaviour
    {
        public float speed;
        public int maxHealth = 100;  // เพิ่มตัวแปร maxHealth
        private int currentHealth;   // เพิ่มตัวแปร currentHealth
        private int jump;
        private float x, sx;
        private bool ks;
        private Animator am;
        private Rigidbody2D rb;
        public Slider healthBar;  // ตัวแปร Slider สำหรับแถบเลือด

        // Start is called before the first frame update
        void Start()
        {
            jump = 0;
            am = GetComponent <Animator>();
            rb = GetComponent <Rigidbody2D>();
            sx = transform.localScale.x;
            currentHealth = maxHealth;  // ตั้งค่าพลังชีวิตเริ่มต้นเป็นพลังชีวิตสูงสุด
            healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        }
        public void TakeDamage(int damage)
        {
            currentHealth -= damage;  // ลดพลังชีวิตตามค่าดาเมจที่ได้รับ
            Debug.Log("Player took " + damage + " damage. Current health: " + currentHealth);

            healthBar.value = currentHealth;

            if (currentHealth <= 0)
            {
                Die();  // ถ้าพลังชีวิตหมด ให้เรียกฟังก์ชัน Die
            }
        }

        // ฟังก์ชันสำหรับการตาย

        // Update is called once per frame
        void Update()
        {
            x = Input.GetAxis ("Horizontal");
            am.SetFloat("speed", Abs(x));
            if(Input.GetButtonDown("Jump")&& jump<2)
            {
                jump++;
                am.SetBool("jump", true);
                rb.linearVelocity = new Vector2 (rb.linearVelocity.x, 5f);
            }
                rb.linearVelocity = new Vector2 (x * speed, rb.linearVelocity.y);
            if (x > 0)
            {
                transform.localScale = new Vector3 (sx, transform.localScale.y, transform.localScale.z);
            }
            if (x < 0)
        {
            am.SetBool("jump", false);
            jump = 0;
        }
        }
        float Abs(float x)
        {
            return x  >=0f? x : -x;
        }
        void Die()
        {
            Debug.Log("Player died.");
            Destroy(gameObject);  // ลบ Player เมื่อพลังชีวิตหมด
        }
        float A(float x)
        {
            return x >= 0f ? x : -x;
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            // เช็คว่าชนกับวัตถุที่มี HealthController หรือไม่
            if (other.CompareTag("Danger"))
            {
                // สมมติว่าวัตถุที่ทำให้เกิดดาเมจมีค่าดาเมจเป็น 10
                TakeDamage(10);  // เรียกฟังก์ชัน TakeDamage
            }
        }
    }