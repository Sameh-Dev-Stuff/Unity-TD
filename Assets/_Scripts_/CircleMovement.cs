using UnityEngine;
using DG.Tweening;

public class CircleMovement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float radius = 2f;
    [SerializeField] private float speed = 2f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;

        transform.DOMove(
                startPosition + Vector3.right * radius,
                1f / speed
            )
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo)
            .OnUpdate(MoveInCircle);
    }

    private void MoveInCircle()
    {
        float angle = Time.time * speed;

        Vector3 offset = new Vector3(
            Mathf.Cos(angle) * radius,
            0f,
            Mathf.Sin(angle) * radius
        );

        transform.position = startPosition + offset;
    }
}