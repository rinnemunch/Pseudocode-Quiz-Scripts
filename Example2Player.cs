using UnityEngine;

public class Example2Player : MonoBehaviour
{
    [SerializeField] private Animator _animator; 
    [SerializeField] private float _damage = 10f;

    void Update()
    {
        // When player presses attack button  
        // Play attack animation  
        // Deal damage after animation finishes

        if (Input.GetKeyDown(KeyCode.F))
        {
            _animator.SetTrigger("Attack");
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            Example2Enemy enemyHealth = other.GetComponent<Example2Enemy>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(_damage);
            }
        }
    }
}
