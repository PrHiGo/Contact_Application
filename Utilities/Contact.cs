namespace Contact_Application.Utilities
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phoneNumber;


        public string Name
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set{ _email = value; }
        }

        public int Number
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public Contact(string firstName, string lastName, string email, int phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phoneNumber = phoneNumber;
        }

    };
}
