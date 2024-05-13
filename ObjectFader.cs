using UnityEngine;

public class ObjectFader : MonoBehaviour
{
    public float fadeDuration = 1f; // user-defined fade duration
    public bool startFadedOut = false; // user-defined start state

    private Renderer objectRenderer;
    private Color initialColor;
    private Color targetColor;
    private float elapsedTime = 0f;
    private bool isFading = false;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        initialColor = objectRenderer.material.color;
        targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, startFadedOut ? 0f : 1f);
        objectRenderer.material.color = targetColor;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFading = true;
            targetColor.a = targetColor.a == 0f ? 1f : 0f;
            initialColor.a = targetColor.a == 0f ? 1f : 0f;
            elapsedTime = 0f;
        }

        if (isFading)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);
            objectRenderer.material.color = Color.Lerp(initialColor, targetColor, t);
            if (t == 1f)
            {
                isFading = false;
            }
        }
    }
}
