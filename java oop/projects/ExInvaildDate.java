public class ExInvaildDate extends Exception {

    public ExInvaildDate() {
        super("Invalid date.");
    }

    public ExInvaildDate(String message) {
        super(message);
    }

    public ExInvaildDate(Day currentDay) {
        super(currentDay.toString());
    }

}
