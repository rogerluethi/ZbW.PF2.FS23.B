namespace Einheit11
{
    public class Person
    {
        private string firstName = "Standard Name";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value != null ? value : "not define"; }
        }

        public string GetLastName()
        {
            return LastName;
        }

        private void SetLastName(string value)
        {
            LastName = value;
        }

        public string LastName { get; set; }



    }
}
