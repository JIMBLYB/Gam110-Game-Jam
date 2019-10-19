using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField]
    private Transform headPivot;
    [SerializeField]
    private float aimRotationSpeed = 1.25f;

    private Vector3 mousePosition;
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    { 
        mousePosition = GetMousePos(Input.mousePosition);
        AimingGun(mousePosition.normalized);
        FlipSprite();
        //LimitRotation();
    }

    private void FlipSprite()
    {
        //print(mousePosition.x - mainCamera.transform.position.x);
        if (mousePosition.x - headPivot.position.x >= 0)
        {
            print("Looking Right");
            return;
        }

        else
        {
            print("Looking Left");
        }
    }

    private void AimingGun(Vector3 direction)
    {
        //print(headPivot.transform.up - headPivot.transform.right);
        //print(headPivot.transform.right - headPivot.transform.up);
        //print(headPivot.transform.right + headPivot.transform.up);

        direction -= headPivot.position;
        LerpDirection(direction);
    }

    private void LerpDirection(Vector3 direction)
    {
        Vector3 lerpPosition = Vector3.Lerp(headPivot.transform.right, direction, Time.deltaTime * aimRotationSpeed);
        headPivot.transform.right = lerpPosition;
    }

    private void LerpRotation(Vector3 rotation)
    {
        Vector3 lerpPosition = Vector3.Lerp(headPivot.transform.eulerAngles, rotation, Time.deltaTime * aimRotationSpeed);
        headPivot.transform.rotation = Quaternion.Euler(lerpPosition);
    }

    private void LimitRotation()
    {
        float headPivotRotationZ = headPivot.transform.eulerAngles.z;
        headPivotRotationZ = Mathf.Clamp(headPivotRotationZ, -90, 180);

        headPivot.transform.rotation = Quaternion.Euler(new Vector3(headPivot.transform.eulerAngles.x,
                                                                    headPivot.transform.eulerAngles.y,
                                                                    headPivotRotationZ));

    }

    private Vector3 GetMousePos(Vector3 screenMousePos)
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(screenMousePos);
        return new Vector3(mousePos.x - mainCamera.transform.position.x, mousePos.y - mainCamera.transform.position.y, 0);
    }
}
