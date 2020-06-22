namespace GestContact.Models.Client.Data
{
    public class Contact
    {
        private int _id;
        private string _fname, _lname, _tel, _email;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Contact(string fname, string lname, string tel, string email)
        {
            Fname = fname;
            Lname = lname;
            Tel = tel;
            Email = email;
        }

        internal Contact(int id, string fname, string lname, string tel, string email)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Tel = tel;
            Email = email;
        }
    }
}
