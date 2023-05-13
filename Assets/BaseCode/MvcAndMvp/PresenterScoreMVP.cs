using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.MvcAndMvp
{
    public class PresenterScoreMVP : MonoBehaviour
    {
        [Header("Ui components")] 
        [SerializeField] private Button _addScore;
        [Header("My components")]
        [SerializeField] private ViewScoreMVP _viewScore;
        
        private ModelScoreMVP _modelScoreMvp;

        private void Start()
        {
            _modelScoreMvp = new ModelScoreMVP();
            
            _addScore.onClick.AddListener(() =>  _modelScoreMvp.IncreaseScore());
            _modelScoreMvp.UpdatedScore += (value) => _viewScore.UpdateText(value);
        }
    }
}