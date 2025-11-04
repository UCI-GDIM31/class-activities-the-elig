using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _playerTransform;


    public void StartChase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }

    public void StopChase(Transform player)
    {
        enabled = false;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime);
    }
}
