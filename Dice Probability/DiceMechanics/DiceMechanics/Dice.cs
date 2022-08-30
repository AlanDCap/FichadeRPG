namespace DiceMechanics
{
    internal class Dice
    {
        public string RollD4(int n = 1)
        {
            List<int> rolls = new List<int>();
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                rolls.Add(r.Next(1, 4));
            }

            string rollsString = "";
            int total = 0;
            foreach (int i in rolls)
            {
                rollsString = rollsString + $"{i} ";
                total += i;
            }
            return rollsString.TrimEnd() + $"\nTotal = {total}\nMédia = {Math.Round((double)total / rolls.Count(), 2)}";
        }

        public string RollD6(int n = 1)
        {
            string rollsString = "";
            int count = 0;
            int total = 0;
            int result;
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                result = r.Next(1, 6);
                rollsString = rollsString + $"{result} ";
                total += result;
                count++;
            }
            return rollsString.TrimEnd() + $"\nTotal = {total}\nMédia = {Math.Round((double)total / count, 2)}";
        }

        public string Roll(string dice)
        {
            string[] nRolls = dice.Split("d");
            string rollsString = "";
            int count = 0;
            int total = 0;
            int result;
            Random r = new Random();

            for (int i = 0; i < int.Parse(nRolls[0]); i++)
            {
                result = r.Next(1, int.Parse(nRolls[1]));
                rollsString = rollsString + $"{result} ";
                total += result;
                count++;
            }
            return rollsString.TrimEnd() + $"\nTotal = {total}\nMédia = {Math.Round((double)total / count, 2)}";
        }
    }
}
