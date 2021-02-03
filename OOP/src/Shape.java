public class Shape {

    private String color ;
    private Boolean filled;
    public Shape()
    {

    }
    public Shape(String color, Boolean filled)
    {
        this.color=color;
        this.filled=filled;
    }
    public void setColor(String color) {
        this.color = color;
    }

    public void setFilled(Boolean filled) {
        this.filled = filled;
    }

    public Boolean getFilled() {
        return filled;
    }

    public String getColor() {
        return color;
    }

    public double getArea(){return 0;}
    public double getPremiter() { return 0; }

    @Override
    public String toString() {
        return "Shape{" +
                "color='" + color + '\'' +
                ", filled='" + filled + '\'' +
                ", area=" +this.getArea()+
                ", permiter=" +this.getPremiter()+
                '}';
    }
}
