using TMPro;
using UnityEngine;

namespace BaseCode.MvcAndMvp
{
    public class ViewScoreMVC : MonoBehaviour
    {
        [Header("Ui components")]
        [SerializeField] private TextMeshProUGUI _scoreText;

        public void UpdateText(int value) => _scoreText.text = value.ToString();
    }
}
