using UnityEngine;
using UnityEngine.UI;

public class ImageScaler : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private float _minScale = 0.5f;
    [SerializeField] private float _scaleSpeed = 1.0f;

    private const float MaxScale = 1.0f;

    private void Update()
    {
        float time = Mathf.PingPong(Time.time * _scaleSpeed, 1.0f);
        float scale = Mathf.Lerp(MaxScale, _minScale, time);

        _image.rectTransform.localScale = new Vector2(scale, scale);
    }
}