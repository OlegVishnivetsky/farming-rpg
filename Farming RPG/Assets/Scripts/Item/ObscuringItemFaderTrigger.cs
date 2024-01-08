using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ObscuringItemFaderTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        ObscuringItemFader[] obscuringItemFaders = other.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFaders.Length <= 0)
        {
            return;
        }

        foreach (ObscuringItemFader obscuringItemFader in obscuringItemFaders)
        {
            obscuringItemFader.FadeOut();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        ObscuringItemFader[] obscuringItemFaders = other.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFaders.Length <= 0)
        {
            return;
        }

        foreach (ObscuringItemFader obscuringItemFader in obscuringItemFaders)
        {
            obscuringItemFader.FadeIn();
        }
    }
}