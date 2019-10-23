#pragma warning disable 0649
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField]
    private Transform playerParent;
    [SerializeField]
    private Transform headPivot;
    [SerializeField]
    private Transform firingPos;
    [SerializeField]
    private float aimRotationSpeed = 1.25f;
    [Range(-1, 1)]
    [SerializeField]
    private float rotationLimiter;

    private Vector3 originalHeadScale;

    private Vector3 mousePosition;
    private Camera mainCamera;

    [SerializeField]
    private GameObject particlePrefab;
    private Animator anim;

    private void Start()
    {
        mainCamera = Camera.main;
        originalHeadScale = playerParent.localScale;

        anim = playerParent.GetComponent<Animator>();
    }

    private void Update()
    { 
        mousePosition = GetMousePos(Input.mousePosition);

        if (mousePosition.normalized.y > rotationLimiter)
        {
            FlipSprite();
        }

        FireGun(KeyCode.Mouse0);
    }

    private void FireGun(KeyCode input)
    {
        if (Input.GetKeyDown(input))
        {
            anim.SetTrigger("PlayerShoot");

            Vector3 direction = firingPos.right;
            direction *= playerParent.localScale.x;
            ParticleManager.Instance.SpawnParticle(particlePrefab, firingPos.position, direction);
        }
    }

    private void FlipSprite()
    {
        if (mousePosition.x >= 0)
        {
            playerParent.localScale = originalHeadScale;
            AimingGun(mousePosition.normalized);
            return;
        }

        else
        {
            playerParent.localScale = new Vector3(-originalHeadScale.x, originalHeadScale.y, originalHeadScale.z);
            AimingGun(-mousePosition.normalized);
        }
    }

    private void AimingGun(Vector3 direction)
    {
        headPivot.transform.right = direction;
    }

    private Vector3 GetMousePos(Vector3 screenMousePos)
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(screenMousePos);
        return new Vector3(mousePos.x - headPivot.position.x, mousePos.y - headPivot.position.y, 0);
    }
}
