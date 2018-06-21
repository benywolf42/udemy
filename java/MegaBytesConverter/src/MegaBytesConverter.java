
public class MegaBytesConverter {
	public static void main(String[] args) {
		printMegaBytesConverter(2060);
	}
	
	public static void printMegaBytesConverter(int kiloBytes) {
		if (kiloBytes < 0) {
			System.out.println("Invalid Value");
		}
		int XX = kiloBytes;
		int YY = kiloBytes / 1024;
		int ZZ = kiloBytes % 1024;
		System.out.println(XX + " KB = " + YY + " MB and "+ ZZ + " KB");
	}

}



