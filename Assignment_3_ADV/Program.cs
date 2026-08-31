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

            #region Exercise 3: Phone Book
            //1.
            //Dictionary<string, int> PhonBook = new()
            //{
            //    {"Marwan",01222648797},
            //    {"Mariam",01229844442},
            //    {"Hamza",01033768045},
            //    {"Mohamed",01277323956}
            //};

            //2.
            //PhonBook["Sara"] = 01228976214;

            //3.
            //try
            //{
            //    PhonBook.Add("Marwan", 01229844442);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Error you try add same exist key");
            //}
            //finally
            //{
            //    Console.WriteLine("Error : Donnt Try Add Duplicate Key");
            //}

            //4.
            //bool resultOfAdding= PhonBook.TryAdd("Marwan",01229844442);
            //   Console.WriteLine(resultOfAdding);

            //5.
            //bool resultOfSearch = PhonBook.TryGetValue("Memo",out int val);
            //Console.WriteLine(resultOfSearch);

            //6.
            // bool resultOfSearch = PhonBook.TryGetValue("Memo", out int val);
            // if (resultOfSearch)
            //     Console.WriteLine($"Found => {val}");
            // else
            //     Console.WriteLine("Not Found"); 

            //7.
            //foreach (string value in PhonBook.Keys)
            //    Console.Write($"{value} ,");
            //Console.WriteLine();
            //foreach (int value in PhonBook.Values)
            //    Console.Write($"{value} ,");



            #endregion

            #region Exercise 4: Unique Email Validator
            //1.
            //HashSet<string> hashset01 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)

            //2.
            //{
            //     "ahmed@test.com",
            //     "AHMED@test.com",
            //     "sara@test.com",
            //     "Sara@Test.Com"
            //};

            //3.
            //Console.WriteLine($"{hashset01.Count}"); // = 2;
            /*Explain:
                 i use (StringComparer.OrdinalIgnoreCase) 
                 and add => (sara captil and small) in compiler defin as one item
             */

            //4.
            //HashSet<int> A = [ 1, 2, 3, 4, 5 ];
            //HashSet<int> B =  [4, 5, 6, 7, 8] ;
            //HashSet<int> D =  [1,2] ;

            //5.
            //A.UnionWith(B);
            //ConsolHelper.PrintHashSet(A);

            // A.IntersectWith(B);
            //ConsolHelper.PrintHashSet(A);

            //A.ExceptWith(B);
            //ConsolHelper.PrintHashSet(A);

            // A.SymmetricExceptWith(B);
            // ConsolHelper.PrintHashSet(A);

            //6.
            //bool result= D.IsSubsetOf(A);  
            //Console.WriteLine(result);

            #endregion

            #region Exercise 5: Print Queue Simulator 
            //1.
            //Queue<string> q1 = new Queue<string>();
            //q1.Enqueue("Report.pdf");
            //q1.Enqueue("Invoice.pdf");
            //q1.Enqueue("Letter.docx");
            //q1.Enqueue("Resume.pdf");
            //q1.Enqueue("Photo.jpg");

            //Console.WriteLine($"Count Of Queue = {q1.Count}");
            //foreach (string item in q1)
            //{
            //    Console.WriteLine(item); ;
            //}

            //2.
            //Console.WriteLine($"Queue Befor Peek And Count = {q1.Count}");
            //foreach (string item in q1)
            //{
            //    Console.WriteLine(item); ;
            //}
            //q1.Peek();
            //Console.WriteLine($"Queue After Peek And Count = {q1.Count}");
            //foreach (string item in q1)
            //{
            //    Console.WriteLine(item); ;
            //}

            //3.
            //for(int i = 0; i < q1.Capacity; i++)
            //{
            //    if(q1.Count>0)
            //    {
            //        string q = q1.Dequeue();
            //        Console.WriteLine($"Printing: {q}");
            //    }

            //}

            //4.
            // If the Queue is empty, TryDequeue returns false
            // So, if I store the result in a bool variable and print it, it will print false
            // If I use the out parameter, it will contain the default value 
            //EX
            //for (int i = 0; i < q1.Capacity; i++)
            //{
            //    if (q1.Count > 0)
            //    {
            //        q1.Dequeue();

            //    }
            //}          
            //bool r = q1.TryDequeue(out string? h);
            //Console.WriteLine(r);
            //Console.WriteLine(h??"Null");
            #endregion

            #region Exercise 6: Browser History (Undo)
            //1.
            //Stack<string> s1 = new Stack<string>();
            //s1.Push("google.com");
            //s1.Push("github.com");
            //s1.Push("stackoverflow.com");
            //s1.Push("youtube.com");
            //s1.Push("claude.ai");

            //2.
            //Console.WriteLine(s1.Peek());

            //3.
            //Console.WriteLine($"{s1.Pop()}=> leave");
            //Console.WriteLine($"{s1.Pop()}=> leave");
            //Console.WriteLine($"{s1.Pop()}=> leave");

            //4.
            //Console.WriteLine($"{s1.Pop()}=>  current page after going back ");

            //5.
            // If the Stack is empty, TryPop returns false
            // So, if I store the result in a bool variable and print it, it will print false
            // If I use the out parameter, it will contain the default value 
            //EX
           //for (int i = 0; i < s1.Capacity; i++)
           //{
           //    if (s1.Count > 0)
           //    {
           //        s1.Pop();
           //
           //    }
           //}
           //bool r = s1.TryPop(out string? h);
           //Console.WriteLine(r);
           //Console.WriteLine(h ?? "Null");

            #endregion
        }
    }
}
