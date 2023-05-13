using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.MvcAndMvp
{
    public class PresenterScoreMVP : MonoBehaviour
    {
        [Header("Ui components")] 
        [SerializeField] private Button _addScore;
        [Header("My components")]
        [SerializeField] private ModelScore _modelScore;
        [SerializeField] private ViewScoreMVP _viewScore;

        private void Start()
        {
            _addScore.onClick.AddListener(() =>  _modelScore.IncreaseScore());
            _modelScore.UpdatedScore += (value) => _viewScore.UpdateText(value);
        }
    }
}