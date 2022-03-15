namespace ForTest
{
    internal class Teacher : BaseInfo
    {
        private Dictionary<Subject, List<string>> _subjects = new Dictionary<Subject, List<string>>(); // Subject -> Groups -> Grades for each group
        public Dictionary<Subject, List<string>> Subjects
        { 
            get { return _subjects; } 
            set { _subjects = value; } // Заменить на функцию заполнения
        }
    }
}
