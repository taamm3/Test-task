using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabler : MonoBehaviour
{
    [SerializeField] private Button _buttonToEnable;

    void OnMouseDown()
    {
        if (_buttonToEnable != null)
        {
            _buttonToEnable.interactable = true;
            AudioManager.Instance.PlaySoundFX();
        }
    }
}
