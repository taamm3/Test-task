using UnityEngine;

public class SpriteClickHandler : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource _voiceSource;

    private void OnMouseDown()
    {
        animator.Play("turn_around_animation");
        _voiceSource.PlayOneShot(_voiceSource.clip);
    }
}
