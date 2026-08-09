using UnityEngine;
using DG.Tweening;

public class VerticalPingPong : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float height = 2f;
    [SerializeField] private float duration = 1f;

    [Header("Ease")]
    [SerializeField] private Ease ease = Ease.InOutSine;

    private void Start()
    {
        transform.DOMoveY(
                transform.position.y + height,
                duration
            )
            .SetEase(ease)
            .SetLoops(-1, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        transform.DOKill();
    }
}