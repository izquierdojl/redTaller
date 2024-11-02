
namespace redTaller.Util
{
    public class Session
    {

        private static Session _instance;
        private static readonly object _lock = new object();

        public string User { get; set; }
        public string Password { get; set; }

        private Session() { }

        public static Session Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Session();
                    }
                    return _instance;
                }
            }
        }

        public void SetSession(string user, string password)
        {
            this.User = user;
            this.Password = password;   
        }

        public void Clear()
        {
            this.User = null;
            this.Password = null;
        }

    }

}
