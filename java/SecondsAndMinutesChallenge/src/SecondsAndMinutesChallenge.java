


public class SecondsAndMinutesChallenge {
	
	private static final String INVALID_VALUE_MESSAGE = "Invalid value";
	
	public static void main(String[] args) {
		System.out.println(getDurationString(120, 46));
		System.out.println(getDurationString(655));
		System.out.println(getDurationString(42, 59));
	}
	public static String getDurationString(int minutes, int seconds) {
		if (minutes >= 0 && seconds >= 0 && seconds <= 59) {
			seconds = seconds + (minutes * 60);
			int hours = seconds / 3600;
			minutes = (seconds % 3600) / 60;
			seconds = (seconds % 3600) % 60;
			String hoursString = hours + "h";
			if (hours < 10) {
				hoursString = "0" + hoursString;
			}
			
			String minutesString = minutes + "m";
			if (minutes < 10) {
				minutesString = "0" + minutesString;
			}
			
			String secondsString = seconds + "s";
			if (seconds < 10) {
				secondsString = "0" + secondsString;
			}
			
			return hoursString + minutesString + secondsString;
		}
		return INVALID_VALUE_MESSAGE;
	}
	
	public static String getDurationString(int seconds) {
		if (seconds >= 0) {
			int minutes = (seconds % 3600) / 60;
			seconds = (seconds % 3600) % 60;
			return getDurationString(minutes, seconds);
		} 
		return INVALID_VALUE_MESSAGE;
	}
	
}


