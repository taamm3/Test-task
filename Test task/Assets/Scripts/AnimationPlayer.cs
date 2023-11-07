using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] private Animation _animationToPlay;

    void OnMouseDown()
    {
        if (_animationToPlay != null)
        {
            _animationToPlay.Play();
        }
    }
}
