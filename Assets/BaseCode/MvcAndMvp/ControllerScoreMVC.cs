using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.MvcAndMvp
{
    public class ControllerScoreMVC : MonoBehaviour
    {
        [Header("Ui components")] 
        [SerializeField] private Button _addScore;

        [Header("My components")] 
        [SerializeField] private ViewScoreMVC _viewScoreMvc;
        
        private ModelScoreMVC _modelScore;

        private void Start()
        {
            _modelScore = new ModelScoreMVC(_viewScoreMvc);
            _addScore.onClick.AddListener(() => _modelScore.IncreaseScore());
        }
    }
}