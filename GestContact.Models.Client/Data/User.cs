namespace GestContact.Models.Client.Data
{
    public class User
    {
        private int _id;
        private string _fname, _lname, _email, _pwd;


        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Fname
        {
            get { return _fname; }
            private set { _fname = value; }
        }

        public string Lname
        {
            get { return _lname; }
            private set { _lname = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Pwd
        {
            get { return _pwd; }
            private set { _pwd = value; }
        }

        public User(string fname, string lname, string email, string pwd)
        {
            Fname = fname;
            Lname = lname;
            Email = email;
            Pwd = pwd;
        }

        internal User(int id, string fname, string lname, string email)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Email = email;
        }
    }
}
