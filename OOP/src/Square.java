public class Square extends Rectangle {
    public  Square()
    {

    }

    @Override
    public void setColor(String color) {
        super.setColor(color);
    }

    @Override
    public void setFilled(String filled) {
        super.setFilled(filled);
    }

    public void setLength(double length) {
       super.setLength(length);
    }

    public double getLength() {
        return super.getLength();
    }

    @Override
    public double getArea() {
        return super.getLength()*super.getLength();
    }
    public double getPremiter() {
        return (4*super.getLength());
    }

    @Override
    public String toString() {
        return "Square{" +
                "length=" + super.getLength() +
                ", area=" +this.getArea()+
                ", permiter=" +this.getPremiter()+
                '}';
    }
}
