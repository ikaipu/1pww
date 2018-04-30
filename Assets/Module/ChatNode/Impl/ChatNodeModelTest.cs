using NSubstitute;
using NUnit.Framework;

namespace MyModule.ChatNode.Impl
{
    public class ChatNodeModelTest
    {   
        private ChatNodeModel _chatNodeModel;
        private ChatNodePresenter _chatNodePresenter;

        [SetUp]
        public void SetUp()
        {
            _chatNodePresenter = Substitute.For<ChatNodePresenter>();
            _chatNodeModel = new ChatNodeModel();
            _chatNodeModel.SetPresenter(_chatNodePresenter);
            throw new System.NotImplementedException();
        }

        [Test]
        public void TestOnShow()
        {
            _chatNodeModel.OnShow();
            throw new System.NotImplementedException();
        }

    }
}