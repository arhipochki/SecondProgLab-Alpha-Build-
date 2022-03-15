namespace ForTest
{
    internal interface IRating
    {
        public double Rating { get; }

        public Dictionary<string, int> Grades { get; set; }

        public void CalculateRating();
    }
}
