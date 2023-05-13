using TMPro;
using UnityEngine;

namespace BaseCode.MvcAndMvp
{
    public class ViewScoreMVC : MonoBehaviour
    {
        [Header("Ui components")]
        [SerializeField] private TextMeshProUGUI _scoreText;

        [Header("My components")] 
        [SerializeField] private ModelScore _modelScore;

        private void Awake() => _modelScore.UpdatedScore += UpdateText;

        private void UpdateText(int value) => _scoreText.text = value.ToString();
    }
}
