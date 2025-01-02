public class Day implements Cloneable{

    private static final String MonthNames = "JanFebMarAprMayJunJulAugSepOctNovDec";

	public static int parseInt(String sDay) throws ExInvaildDate{
		 try {
			String[] sDayPart = sDay.split("-");
			if(sDayPart.length != 3)
				throw new ExInvaildDate();
			int index =  MonthNames.indexOf(sDayPart[1]);
			if(index == -1)
				throw new ExInvaildDate();
			String tempMonth =  "0" + String.valueOf(index/3 + 1);
			String monthStr = tempMonth.substring(tempMonth.length()-2, tempMonth.length());
			String dayString = ("0" + sDayPart[0]).substring(sDayPart[0].length()-1, sDayPart[0].length()+1);
			return Integer.parseInt(sDayPart[2] + monthStr + dayString);
		 } catch(NumberFormatException e) {
			throw new ExInvaildDate();
		 }
	}
	
	private int year;
	private int month;
	private int day;
	
	//Constructor
	public Day(int y, int m, int d) {
		this.year=y;
		this.month=m;
		this.day=d;		
	}

    public Day(String sDay) throws ExInvaildDate{
        set(sDay);
    }
	
	// check if a given year is a leap year
	static public boolean isLeapYear(int y) {
		if (y%400==0)
			return true;
		else if (y%100==0)
			return false;
		else if (y%4==0)
			return true;
		else
			return false;
	}
	
	// check if y,m,d valid
	static public boolean valid(int y, int m, int d) {
		if (m<1 || m>12 || d<1) return false;
		int days = getMonthDays(m, y);
		if(days == 0) 
			return false;
		return d <= days;
	}

	public static int getMonthDays(int m, int y) {
		switch(m){
			case 1: case 3: case 5: case 7:
			case 8: case 10: case 12:
					 return 31; 
			case 4: case 6: case 9: case 11:
					 return 30; 
			case 2:
					 if (isLeapYear(y))
						 return 29; 
					 else
						 return 28; 
		}
		return 0;
	}

	// Return a string for the day like dd MMM yyyy
    @Override
	public String toString() {
		return day + "-" + MonthNames.substring((month - 1)* 3, month*3) + "-" + year;
	}

    public void set(String sDay) throws ExInvaildDate{
		try {
			String[] sDayPart = sDay.split("-");
			if(sDayPart.length != 3)
				throw new ExInvaildDate();
			int index =  MonthNames.indexOf(sDayPart[1]);
			if(index == -1)
				throw new ExInvaildDate();
			int d = Integer.parseInt(sDayPart[0]);
			int m = index/3 + 1;
			int y = Integer.parseInt(sDayPart[2]);
			if(!valid(y, m, d))
				throw new ExInvaildDate();
			day = d;
			month = m;
			year = y;
		} catch(NumberFormatException e) {
			throw new ExInvaildDate();
		} 
    }

    @Override
    public Day clone() {
        Day copy = null;
        try {
            copy = (Day) super.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        return copy;
    }

	public int parseInt() {
		String tempMonth =  "0" + String.valueOf(month);
		String tempDay = "0" + String.valueOf(day);
		String monthStr = tempMonth.substring(tempMonth.length()-2, tempMonth.length());
		String dayString = tempDay.substring(tempDay.length()-2, tempDay.length());
		return Integer.parseInt(String.valueOf(year) + monthStr + dayString);
	}

	public void increment(int n) { 
		for(int i = 0; i < n; i++) {
			int maxDay = getMonthDays(month, year);
			day++;
			if(day > maxDay) {
				month++;
				day = 1;
				if(month > 12) {
					year++;
					month = 1;
				}
			}
		}
	}

}
