using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Animator anim;
    private float life;

    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 3f;
        life = 100f;
        InvokeRepeating(nameof(ApplyDamage), 1.0f, 1.0f);
    }
    private void ApplyDamage()
    {
        TakeDamage(10f);
    }


    void Update()
    {
        // Podemos hacer un if si consideramos que el personaje puede estar sin moverse hasta cierto momento
        agent.SetDestination(target.position);
        anim.SetFloat("Moves", 1f);
        // Agregar un if take damage
        
    }

    public void TakeDamage(float damage)
    {
        // Resta el daño de la vida actual
        life -= 10f;  // Reducción de la vida

        // Puedes agregar más lógica aquí, por ejemplo, activar una animación de recibir daño.
        //animator.Play(HasAmmunition() ? "Reload" : "Reload Empty", 0, 0.0f);


        // Verifica si el enemigo ha quedado sin vida
        if (life <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        anim.SetFloat("Moves", 0f);
        anim.SetFloat("Dies", 1f); // Detener la animación de movimiento
        anim.SetBool("isDead", true); // Puedes tener otro parámetro para la animación de muerte si es necesario
        agent.isStopped = true; // Detener el NavMeshAgent

        Collider enemyCollider = GetComponent<Collider>();
        if (enemyCollider != null)
        {
            enemyCollider.enabled = false;
        }
        
        Destroy(gameObject, 9f);
    }
}