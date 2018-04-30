using MySystem.MVP.Interface;
using UnityEngine;
using UnityEngine.UI;

namespace MyModule.ChatNode.Impl
{
    public class ChatNodeView : BaseView<ChatNodeModel, ChatNodeView, ChatNodePresenter> 
    {
        [SerializeField]
        private Text _chatNodeText;

        [SerializeField]
        private Image _chatNodeImage;

        private void Awake()
        {
        }
    }
}