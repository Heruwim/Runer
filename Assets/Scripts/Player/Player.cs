using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _helth;

    public void ApplyDamage(int damage)
    {
        _helth -= damage;

        if (_helth <= 0)
            Die();
    }

    public void Die()
    {

    }
}
