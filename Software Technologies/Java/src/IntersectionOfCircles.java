import java.util.Scanner;

public class IntersectionOfCircles {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] firstCircleArgs = sc.nextLine().split("\\s+");
        String[] secondCircleArgs = sc.nextLine().split("\\s+");

        Point firstCircleCentre = new Point(Integer.parseInt(firstCircleArgs[0]), Integer.parseInt(firstCircleArgs[1]));
        int firstCircleRadius = Integer.parseInt(firstCircleArgs[2]);
        Circle firstCircle = new Circle(firstCircleCentre, firstCircleRadius);

        Point secondCircleCentre = new Point(Integer.parseInt(secondCircleArgs[0]), Integer.parseInt(secondCircleArgs[1]));
        int secondCircleRadius = Integer.parseInt(secondCircleArgs[2]);
        Circle secondCircle = new Circle(secondCircleCentre, secondCircleRadius);

        double distanceBetweenRadiuses = Math.sqrt(Math.pow(firstCircle.getCentre().getX() - secondCircle.getCentre().getX(), 2) + Math.pow(firstCircle.getCentre().getY() - secondCircle.getCentre().getY(), 2));

        if (distanceBetweenRadiuses > firstCircle.getRadius() + secondCircle.getRadius()){
            System.out.println("No");
        } else {
            System.out.println("Yes");
        }
    }
}

class Point{
    private int x;
    private int y;

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }
}

class Circle{
    private Point centre;
    private int radius;

    public Circle(Point centre, int radius) {
        this.centre = centre;
        this.radius = radius;
    }

    public Point getCentre() {
        return centre;
    }

    public void setCentre(Point centre) {
        this.centre = centre;
    }

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        this.radius = radius;
    }
}
