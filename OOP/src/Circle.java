public class Circle extends Shape{
    private double radius;
    public Circle()
    {

    }
    public Circle( float radius)
    {
        this.radius=radius;
    }
    public Circle( float radius,String color,Boolean filled)
    {
        super(color,filled);
        this.radius=radius;
    }
    public double getArea()
    {
        return (3.14*radius*radius);
    }
    public double getPremiter() {
        return radius*2*3.14;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public double getRadius() {
        return radius;
    }

    @Override
    public String toString() {
        return "Circle{" +
                "radius=" + radius +
                ", area=" +this.getArea()+
                ", permiter=" +this.getPremiter()+
                '}';
    }
}
