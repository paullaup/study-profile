public class Reservation implements Comparable<Reservation>{
    
    private Member member;
    private Day starDay;
    private Day lastDay;
    private EquipmentSet set;


    public Reservation(Member member, Day starDay, Day lastDay) {
        this.member = member;
        this.starDay = starDay;
        this.lastDay = lastDay;
    }

    public boolean isOverlap(Day starDay, Day lastDay) {
        try {
            int[] period1 = {Day.parseInt(this.starDay.toString()), Day.parseInt(this.lastDay.toString())};
            int[] period2 = {Day.parseInt(starDay.toString()), Day.parseInt(lastDay.toString())};
            // if( (period2[0] >= period1[0] && period2[0] <= period1[1]) || (period2[1] >= period1[0] && period2[1] <= period1[1]) || (period2[0] <= period1[0] && period2[1] >= period1[1]) )
            //     return true;
            if( (period2[0] < period1[0] && period2[1] < period1[0] ) || (period2[0] > period1[1] && period2[1] > period1[1]) )
                return false;
        } catch(ExInvaildDate e) {
            //ExInvaildDate suppose not to occur
        }
        return true;
    }

    public boolean isOverlap(Reservation reservation) {
        return isOverlap(reservation.starDay, reservation.lastDay);
    }

    @Override
    public int compareTo(Reservation reservation) {
        int compareStartDay = ((Integer)starDay.parseInt()).compareTo((Integer)reservation.starDay.parseInt());
        if(compareStartDay == 0) 
            return set.compareTo(reservation.set);
        return compareStartDay;
    }

    @Override
    public String toString() {
        String action = (isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))? "borrows" : "requests";
        String s = String.format("%s %s %s for %s to %s", member, action, set, starDay, lastDay);
        return s;
    }

    public String getMemberReservationString() {
        String action = (isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))? "borrows" : "requests";
        return String.format("%s %s for %s to %s",action, set, starDay, lastDay);
    }

    public String getEquipmentStatusString() {
        String action = (isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))? "borrows" : "requests";
        return String.format("%s %s for %s to %s", member, action, starDay, lastDay);
    }

    public Member getMember() {
        return member;
    }

    public Day getStartDay() {
        return starDay;
    }

    public void setEquipmentSet(EquipmentSet set) {
        this.set = set;
    }

    public String getPeriodString() {
        return String.format("%s to %s", starDay, lastDay);
    }

    public void remove() {
        set.cancelReservation(this);
        member.cancelReservation(this);
    }

    public void reAdd() throws ExRepeatedBorrow{
        set.submitReservation(this);
    }

}
