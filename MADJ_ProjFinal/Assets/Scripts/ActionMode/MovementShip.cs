using UnityEngine;
using Unity.Netcode;

public class MovementShip : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody rigidBody;

    void Start()
    {

    }

    void Update()
    {
        if (!IsOwner) { return; }

        if (Input.GetMouseButton(0))
        {
            BulletManager.Instance.SpawnBulletServerRpg();
        }
    }

    private void UpdateMovementServerAuth()
    {
        Vector3 moveDirection = Vector3.zero;

        
    }

    [ServerRpc(RequireOwnership = false)]
    private void UpdateMovementServerRpc()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(""))
        {
            /*if(IsServer)
            {

            }*/
        }
    }
}
