using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.MvcAndMvp
{
    public class ControllerScoreMVC : MonoBehaviour
    {
        [Header("Ui components")] 
        [SerializeField] private Button _addScore;
        [Header("My components")]
        [SerializeField] private ModelScore _modelScore;

        private void Start() => 
            _addScore.onClick.AddListener(() => _modelScore.IncreaseScore());
    }
}