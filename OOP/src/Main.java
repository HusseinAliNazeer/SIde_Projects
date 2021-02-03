public class Main {

    public static void main(String[] args) {
	// write your code here
        //create Circle Object
        Circle circle=new Circle();
        circle.setRadius(5);
        System.out.println(circle.toString());
        Square square=new Square();
        square.setLength(3);
        System.out.println(square.toString());
        Rectangle rectangle =new Rectangle();
        rectangle.setLength(3);
        rectangle.setWidth(2);
        System.out.println(rectangle.toString());
        Cylinder cylinder=new Cylinder();
        cylinder.setRadius(3.5);
        cylinder.setHeight(4);
        System.out.println(cylinder.toString());
    }
}
