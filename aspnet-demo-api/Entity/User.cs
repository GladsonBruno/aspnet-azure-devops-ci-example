namespace aspnet_demo_api.Entity
{
    public class User
    {

        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        public User(int id, string username, string email)
        {
            
            this.id = id;
            this.username = username;
            this.email = email;

        }

    }

}
