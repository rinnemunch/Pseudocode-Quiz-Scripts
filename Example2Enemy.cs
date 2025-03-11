using UnityEngine;
using System.Collections;

public class Example2Enemy : MonoBehaviour
{
    [SerializeField] private float _health = 30f; 
    [SerializeField] private Renderer _renderer; 
    [SerializeField] private Color _damageColor = Color.red;
    [SerializeField] private float _flashDuration = 0.2f;

    private Color _originalColor; 

    private void Start()
    {
        
        _originalColor = _renderer.material.color;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        Debug.Log("Enemy took damage! Remaining health: " + _health);

       
        StartCoroutine(FlashRed());

        if (_health <= 0)
        {
            Die();
        }
    }

    private IEnumerator FlashRed()
    {
    
        _renderer.material.color = _damageColor;

       
        yield return new WaitForSeconds(_flashDuration);

   
        _renderer.material.color = _originalColor;
    }

    private void Die()
    {
        Debug.Log("Enemy Defeated!");
        Destroy(gameObject); 
    }
}
