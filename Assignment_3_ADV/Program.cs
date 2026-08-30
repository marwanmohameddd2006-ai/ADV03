namespace Assignment_3_ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //1.
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            //2.
            //Console.WriteLine($"Count = {grades.Count} , First grad = {grades[0]}/100 , Last grad  = {grades[^1]}/100");

            //3.
            //grades.Sort();
            //foreach( int grade in grades )
            //{
            //    Console.WriteLine(grade);
            //}

            //4.
            //int first_grade_above90 = grades.Find(x=>x>90);
            //Console.WriteLine($"first grade above 90  = {first_grade_above90}");

            //5.
            //List<int> failinggrades = grades.FindAll(x => x < 75);
            //foreach (int grade in failinggrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //6.
            //failinggrades.Clear();

            //7.
            //Console.WriteLine(grades.Contains(100)) ;

            //8.
            //Failed

            #endregion

            #region Exercise 2: Leaderboard
            //1.
            //Dictionary<int, string> playersScore = new()
            //{
            //    { 500,"Ahmed"},
            //    {200,"Sara"},
            //    {800,"Ali"},
            //    { 350,"Mona"}
            //};

            //2.
              //foreach (KeyValuePair<int, string> pair in playersScore)
             //Console.WriteLine(pair.Key);

            //3.
              //string val = playersScore[500];
              //Console.WriteLine($"First Value in Dict => {val} ");

            //4.
             //bool isexist  = playersScore.ContainsKey(500);
             //Console.WriteLine(isexist);

            //5.
           //playersScore.TryGetValue(999, out string? score);
           //Console.WriteLine(score??"Null");

            //6.
            //playersScore.Remove(200);
            //foreach (KeyValuePair<int, string> pair in playersScore)
            //Console.WriteLine(pair);



            #endregion
        }
    }
}
