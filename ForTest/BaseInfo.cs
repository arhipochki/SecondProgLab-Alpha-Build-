namespace ForTest
{
    internal class BaseInfo : IName, IRating
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _rating = 0;
        public double Rating
        {
            get { return _rating; }
        }

        private Dictionary<string, int> _grades = new Dictionary<string, int>();
        public Dictionary<string, int> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public void CalculateRating()
        {
            foreach (var subject in _grades)
            {
                _rating += subject.Value;
            }

            _rating /= _grades.Count;
        }
    }
}
