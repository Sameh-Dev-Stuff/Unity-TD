using UnityEngine;
using DG.Tweening;
using NaughtyAttributes;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform[] pathPoints;
    [SerializeField] private float speed = 2f;
    private WaveManager waveManager;

    [SerializeField,ReadOnly] private int index;
    
    [Header("Ease")]
    [SerializeField] private Ease ease = Ease.Linear;
    

    private void Start()
    {
        waveManager = FindAnyObjectByType<WaveManager>();
        pathPoints = waveManager.pathPoints;
        MoveToNextPoint();
    }

    private void MoveToNextPoint()
    {
        if (index >= pathPoints.Length)
        {
            ReachBase();
            return;
        }

        Transform target = pathPoints[index];

        float distance = Vector3.Distance(transform.position, target.position);

        float duration = distance / speed;

        transform.DOMove(target.position, duration).SetEase(ease).OnComplete(() =>
        {
            
            index++;
            MoveToNextPoint();
            
        });
    }

    private void ReachBase()
    {
        Debug.Log("Enemy reached the base!");
        Destroy(gameObject);
    }
}