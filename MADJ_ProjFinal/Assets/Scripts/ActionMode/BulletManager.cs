using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class BulletManager : MonoBehaviour
{
    public static BulletManager Instance { get; private set; }

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _secondsBeforeNewFire;
    [SerializeField] private float _secondsBeforeKillBullet;

    private void OnEnable()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogWarning("Multiple BulletManager instances are not allowed");
            Destroy(gameObject);
        }
    }

    [ServerRpc(RequireOwnership = false)]
    public void SpawnBulletServerRpg(Vector3 shotPosition)
    {
        
    }

    private IEnumerator WaitToClearNumberOfBullets()
    {
        yield return new WaitForSeconds(_secondsBeforeNewFire);

        
    }

    private IEnumerator WaitToKillBullets(GameObject bullet)
    {
        yield return new WaitForSeconds(_secondsBeforeKillBullet);

        if(bullet != null)
        {
            Destroy(bullet);
            bullet.GetComponent<NetworkObject>().Despawn(true);
        }
    }
}
