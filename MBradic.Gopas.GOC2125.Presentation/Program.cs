class Program {
    public static void Main(string[] args) {
        Circle small = new(5);
        Circle big = new(25);
        PrintCircleInfo(small, big);

        Circle.PI = 4;
        PrintCircleInfo(small, big);
    }
    private static void PrintCircleInfo(Circle small, Circle big) {
        Console.WriteLine($"PI = {Circle.PI}");
        Console.WriteLine($"small.Area = {small.Area}");
        Console.WriteLine($"big.Area = {big.Area}");
        Console.WriteLine();
    }
}