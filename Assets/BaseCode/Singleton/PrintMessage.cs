using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.Singleton
{
    public class PrintMessage : MonoBehaviour
    {
        [SerializeField] private Button _buttonMessage;
        [SerializeField] private TextMeshProUGUI _textMessage;

        private void Start() => 
            _buttonMessage.onClick.AddListener(Print);

        private void Print() => 
            _textMessage.text = $"{Message.Instance.MessageText} \n {Message2.Instance.MessageText}";
    }
}