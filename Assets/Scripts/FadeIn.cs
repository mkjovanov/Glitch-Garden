using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
	public class FadeIn : MonoBehaviour
	{
		public int FadeInTime;

		private Image _fadePanel;
		private Color _currentColor = Color.black;

		private void Start()
		{
			_fadePanel = GetComponent<Image>();
		}

		private void Update()
		{
			if (Time.timeSinceLevelLoad < FadeInTime)
			{
				var alphaChange = Time.deltaTime / FadeInTime;
				_currentColor.a -= alphaChange;
				_fadePanel.color = _currentColor;
			}
			else
			{
				gameObject.SetActive(false);
			}
		}
	}
}
