int[][] a = new int[3][] {
                new int[4] {5, 3, 4, 7},
                new int[1] {6},
                new int[2] {1, 9, }
            };

for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < a[i].Length; j++)
    {
        Console.WriteLine (($"[{i},{j}]={a[i][j]}") 
        );
    }
}