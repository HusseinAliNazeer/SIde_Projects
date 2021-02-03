public class Rectangle extends Shape{
    private  double length,width;

    public Rectangle()
    {

    }
    public Rectangle(double length ,double width)
    {
        this.length=length;
        this.width=width;
    }
    public Rectangle(Boolean filled, String color,double length ,double width)
    {
        super(color,filled);
        this.length=length;
        this.width=width;
    }
    public void setLength(double length) {
        this.length = length;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getLength() {
        return length;
    }

    public double getWidth() {
        return width;
    }

    public double getPremiter() {
        return (length+width)*2;
    }

    @Override
    public double getArea() {
        return length*width;
    }

    @Override
    public String toString() {
        return "Triangle{" +
                "length=" + length +
                ", width=" + width +
                ", area=" +this.getArea()+
                ", permiter=" +this.getPremiter()+
                '}';
    }
}
