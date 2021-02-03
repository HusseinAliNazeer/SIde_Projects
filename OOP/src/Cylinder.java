public class Cylinder extends Circle {
   private double height;

    public Cylinder()
    {

    }
    public Cylinder(float radius)
    {
        super(radius);
    }
    public Cylinder(float radius, String color,Boolean filled)
    {
        super(radius,color,filled);
    }

    public void setRadius(double radius) {
        super.setRadius(radius);
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double getRadius() {
        return super.getRadius();
    }

    public double getHeight() {
        return height;
    }

    @Override
    public double getArea() {
        return (2*3.14*super.getRadius()*height)+(3.14*super.getRadius()*height);
    }
    public double getPremiter() {
        return (2*(super.getRadius()*2)+2*height);
    }

    @Override
    public String toString() {
        return "Cylinder{" +
                "radius=" + super.getRadius() +
                ", height=" + height +
                ", area=" +this.getArea()+
                ", permiter=" +this.getPremiter()+
                '}';
    }
}
