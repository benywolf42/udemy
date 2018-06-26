
public class AreaCalculator {
	public static final double PI = 3.14159;
	
	public static void main(String[] args) {
		
	}
	
	public static double area (double radius) {
		if (radius < 0 ) {
			return -1;				
		}
		double calculatedArea = radius * radius * PI;
		return calculatedArea;
	}
	
	public static double area (double x, double y) {
		if (x < 0 || y < 0) {
			return -1;
		}
		double calculatedArea = x * y;
		return calculatedArea;
	}
}
