class Circle {
    public static double PI = 3.14;
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; init; }
    public double Area => PI * Radius * Radius;
}

