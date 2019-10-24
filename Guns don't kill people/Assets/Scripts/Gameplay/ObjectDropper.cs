using UnityEngine;

public enum Tags
{
    Bullet = 0,
    Ball = 1,
    Damage = 2
};


[RequireComponent(typeof(Animator))]
public class ObjectDropper : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToDrop;
    private Rigidbody2D objectToDropRigidBody;
    private bool hasDropped = false;

    [SerializeField]
    private string wireAnimTriggerName = "Dropped";
    private Animator wireAnim;

    [SerializeField]
    private GameObject brokenWireParticle;

    private void Start()
    {
        hasDropped = false;

        objectToDropRigidBody = objectToDrop.GetComponent<Rigidbody2D>();
        wireAnim = this.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.Bullet.ToString()))
        {
            Destroy(collision.gameObject);
            DropObject();
        }
    }

    private void DropObject()
    {
        wireAnim.SetTrigger(wireAnimTriggerName);
        ParticleManager.Instance.SpawnParticle(brokenWireParticle, this.transform.position, Quaternion.identity);

        hasDropped = true;
        objectToDropRigidBody.isKinematic = false;
    }
}
