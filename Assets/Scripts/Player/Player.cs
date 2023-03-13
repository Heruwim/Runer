using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _helth;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        HealthChanged.Invoke(_helth);
    }

    public void ApplyDamage(int damage)
    {
        _helth -= damage;
        HealthChanged?.Invoke(_helth);

        if (_helth <= 0)
            Die();
    }

    public void Die()
    {
        Died?.Invoke();        
    }
}
