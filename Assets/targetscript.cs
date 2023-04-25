using UnityEngine;
using System.Collections;



public class targetscript : MonoBehaviour
{
    public class TargetScript : MonoBehaviour
    {
        public int pointValue = 10;
        public float lifeTime = 17f;
        public float radius = 3f;
        public float speed = 2f;

        private Vector3 center;
        private float angle;

        private bool isHit = false;

        void Start()
        {
            
            Destroy(gameObject, lifeTime);

            
            center = transform.position;

            
            angle = Random.Range(3f, 360f);
        }

        void Update()
        {
            
            angle += speed * Time.deltaTime;

            
            Vector3 offset = new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), 2, Mathf.Cos(angle * Mathf.Deg2Rad)) * radius;
            transform.position = center + offset;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Projectile") && !isHit)
            {
                isHit = true;

                
                 ScoreManager.Instance.AddPoints(pointValue);

                
                Destroy(other.gameObject);

                
                Destroy(gameObject, 0.10f);
            }
        }
    }




}
