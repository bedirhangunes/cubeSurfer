using UnityEngine;

public class cubeController : MonoBehaviour
{
    [SerializeField] private CharStack charStack;
    private bool isStack = false;
    private RaycastHit hit;
    private Vector3 direction = Vector3.back;
    void Start()
    {
        charStack = GameObject.FindObjectOfType<CharStack>();
        
    }

  
    void FixedUpdate()
    {
        SetCubeRaycast();
    }
    private void SetCubeRaycast()
    {
        if(Physics.Raycast(transform.position,direction,out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                charStack.IncreasedBlockStack(gameObject);
                SetDirection();
            }
            if (hit.transform.name == "ObstacleCube")
            {
                charStack.DecreaseBlock(gameObject);
            }
        }
    }
    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
