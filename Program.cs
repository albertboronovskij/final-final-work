

void Main(string[] args)
{
    string[] ea = { "qcs", "qdjjjq", "qd", "qecFFD", "cacsa", "cnKK", "CkaJHHIxab" };

    for (int i = 0; i < ea.Length; i++)
    {
        int length = ea[i].Length;

        if (length < 4)
        {
            string d = ea[i];
            int j = 0;
            string[] eo = new string[j+1];
            eo[j] = d;
            Console.WriteLine(eo[j]);
            j++;
        }
    }
}


Main(args);
