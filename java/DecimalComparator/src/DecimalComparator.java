
public class DecimalComparator {
	
	public static void main(String[] args) {
		System.out.println(areEqualByThreeDecimalPlaces(3.1245, 3.12456));
	}
	
	
	public static boolean areEqualByThreeDecimalPlaces (double d1, double d2){
		double decimalD1 = d1 *1000;
		double decimalD2 = d2 *1000;
		
		if ((int)decimalD1 == (int)decimalD2) {
			return true;
		}
		return false;
	}
}
