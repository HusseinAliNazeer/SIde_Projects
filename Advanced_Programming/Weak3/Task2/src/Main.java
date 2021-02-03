abstract class testAbstract{
    String color;
    abstract double area();
    public abstract String toString();
    abstract String getColor();
}

class Circle extends testAbstract{
    double radius;

    public Circle(Double radius)
    {
        this.radius=radius;
    }

    public double  area()
    {
        return radius*radius*3.14;
    }

    @Override
    public String toString() {
        return "Circle Object";
    }

    public String getColor()
    {
        return "blue";
    }
}

class Rectangle extends testAbstract{
    double width,height;

    public  Rectangle(double width,double height)
    {
        this.height=height;
        this.width=width;
    }

    public double  area()
    {
        return width*height;
    }

    @Override
    public String toString() {
        return "Rectangle  Object";
    }

    public String getColor()
    {
        return "red ";
    }
}

public class Main {

    public static void main(String[] args) {
	// write your code here
        Circle c1=new Circle(5.4);
        Rectangle r1=new Rectangle(4,6);
    }
}
