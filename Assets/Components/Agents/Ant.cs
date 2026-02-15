using UnityEngine;


public class Ant : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public float healthDecayPerStep = 1f;
    private float stepTimer = 0f;
    public float stepInterval = 0.2f;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }
 

    protected virtual void Update()
    {
        stepTimer += Time.deltaTime;

        if (stepTimer >= stepInterval)
        {
            stepTimer = 0f;
            Tick();
        }
    }


    protected virtual void Tick()
    {
        ApplyHealthDecay();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void ApplyHealthDecay()
    {
        currentHealth -= healthDecayPerStep * Time.deltaTime;
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
