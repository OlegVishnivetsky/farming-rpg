using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ObscuringItemFader : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private Coroutine fadeInCoroutine;
    private Coroutine fadeOutCoroutine;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FadeIn()
    {
        if (fadeInCoroutine != null)
        {
            StopCoroutine(fadeInCoroutine);
        }

        if (fadeOutCoroutine != null)
        {
            StopCoroutine(fadeOutCoroutine);
        }

        fadeInCoroutine = StartCoroutine(FadeInRoutine());
    }

    public void FadeOut()
    {
        if (fadeOutCoroutine != null)
        {
            StopCoroutine(fadeOutCoroutine);
        }

        if (fadeInCoroutine != null)
        {
            StopCoroutine(fadeInCoroutine);
        }

        fadeOutCoroutine = StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeInRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float distance = 1f - currentAlpha;

        while (1f - currentAlpha > 0.01f)
        {
            currentAlpha += distance / Settings.fadeInDuration * Time.deltaTime;

            spriteRenderer.color = new Color(spriteRenderer.color.r,
                spriteRenderer.color.g, spriteRenderer.color.b, currentAlpha);

            yield return null;
        }

        spriteRenderer.color = new Color(spriteRenderer.color.r,
                spriteRenderer.color.g, spriteRenderer.color.b, 1f);
    }

    private IEnumerator FadeOutRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float distance = Settings.targetAlpha - currentAlpha;

        while (Settings.targetAlpha - currentAlpha > 0.01f)
        {
            currentAlpha -= distance / Settings.fadeInDuration * Time.deltaTime;

            spriteRenderer.color = new Color(spriteRenderer.color.r,
                spriteRenderer.color.g, spriteRenderer.color.b, currentAlpha);

            yield return null;
        }

        spriteRenderer.color = new Color(spriteRenderer.color.r,
                spriteRenderer.color.g, spriteRenderer.color.b, Settings.targetAlpha);
    }
}