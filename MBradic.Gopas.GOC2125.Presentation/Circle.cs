class Circle : Shape {
    public static double PI = 3.14;
    public Circle(double radius) { 
        Radius = radius;
    }
    public double Radius { get; init; }
    public override double Area => PI * Radius * Radius;
}

