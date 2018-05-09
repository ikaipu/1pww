namespace My.System.Player.Interface
{
    public class PlayerLocator : IPlayerManager
    {
        private static IPlayerManager _playerManager;

        public static readonly PlayerLocator Instance = new PlayerLocator();
       
        private PlayerLocator()
        {
        }
        
        public static void Set(IPlayerManager playerManager)
        {
            _playerManager = playerManager;
        }
    }
}