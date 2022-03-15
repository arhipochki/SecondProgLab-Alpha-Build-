namespace ForTest
{
    internal class Subject : IName
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
