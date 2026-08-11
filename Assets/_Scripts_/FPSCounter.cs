using System;
using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text fpsText;

    [Header("Settings")]
    [SerializeField, Min(0.1f)] private float updateInterval = 0.25f;
    [SerializeField] private int gameTargetFPS = 90;

    [Header("Colors")]
    [SerializeField] private Color goodColor = Color.green;
    [SerializeField] private Color warningColor = Color.yellow;
    [SerializeField] private Color badColor = Color.red;

    private float elapsedTime;
    private int frameCount;

    private float currentFPS;
    private float averageFPS; 
    private float minFPS = float.MaxValue;
    private float maxFPS;
    
    private void Awake()
    {
        Application.targetFrameRate = gameTargetFPS;
    }

    private void Update()
    {
        float deltaTime = Time.unscaledDeltaTime;

        if (deltaTime <= 0f)
        {
            return;
        }

        frameCount++;
        elapsedTime += deltaTime;

        currentFPS = 1f / deltaTime;

        minFPS = Mathf.Min(minFPS, currentFPS);
        maxFPS = Mathf.Max(maxFPS, currentFPS);

        if (elapsedTime >= updateInterval)
        {
            averageFPS = frameCount / elapsedTime;

            UpdateDisplay();

            elapsedTime = 0f;
            frameCount = 0;
            minFPS = float.MaxValue;
            maxFPS = 0f;
        }
    }

    private void UpdateDisplay()
    {
        if (fpsText == null)
        {
            return;
        }

        fpsText.text = $"FPS: {Mathf.RoundToInt(averageFPS)}\n" + $"{1000f / averageFPS:F1} ms";

        fpsText.color = GetFPSColor(averageFPS);
    }

    private Color GetFPSColor(float fps)
    {
        if (fps >= gameTargetFPS / 1.05f)
        {
            return goodColor;
        }

        if (fps >= gameTargetFPS / 1.3f)
        {
            return warningColor;
        }
        return badColor;
    }
}