namespace ForTest
{
    internal class Student : BaseInfo
    {
        private string _group = "";

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
    }
}
