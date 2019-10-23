using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public static ParticleManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
    }

    public void SpawnParticle(GameObject particleEffect, Vector3 position, Quaternion rotation)
    {
        particleEffect = Instantiate(particleEffect, position, rotation);
        Destroy(particleEffect, particleEffect.GetComponent<ParticleSystem>().main.startLifetime.constant);
    }

    public void SpawnParticle(GameObject particleEffect, Vector3 position, Vector3 direction)
    {
        particleEffect = Instantiate(particleEffect, position, Quaternion.identity);
        particleEffect.transform.forward = direction;
        Destroy(particleEffect, particleEffect.GetComponent<ParticleSystem>().main.startLifetime.constant);
    }
    
}
