using Player;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private PlayerEntity _playerEntity;

    private float _horizontalDirection;

    private void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal"); //-1 0 1

        if (Input.GetButtonDown("Jump"))
        {
            _playerEntity.Jump();
        }

	if (Input.GetButtonDown("Fire1"))
            _playerEntity.StartAttack();

    }

    private void FixedUpdate()
    {
        _playerEntity.MoveHorizontally(_horizontalDirection);
    }
}