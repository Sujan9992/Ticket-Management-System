namespace coursework
{
    internal class Weekly
    {
        string day;
        int totalPeople;
        int totalIncome;

        public Weekly(string day, int totalPeople, int totalIncome)
        {
            this.day = day;
            this.totalPeople = totalPeople;
            this.totalIncome = totalIncome;
        }
        public string Day { get { return day; } }
        public int TotalPeople { get { return totalPeople; } }
        public int TotalIncome { get { return totalIncome; } }
    }
}