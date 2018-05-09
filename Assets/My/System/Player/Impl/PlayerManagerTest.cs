using My.System.Player.Interface;
using NUnit.Framework;

namespace My.System.Player.Impl
{
    public class PlayerManagerTest
    {
        private PlayerManager _playerManager;

        [SetUp]
        public void SetUp()
        {
            _playerManager = new PlayerManager();            
        }
    }
}