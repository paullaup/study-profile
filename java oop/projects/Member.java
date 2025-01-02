import java.util.*;


public class Member implements Comparable<Member>{
    
    private String id;
    private String name;
    private Day joinDay;
    private ArrayList<Reservation> reservations;
    private Hashtable<Reservation, Equipment>  reservedEquipments;

    private Day lastUpdatedDay;
    private int borrowNum;
    private int requestNum;

    public static void list(ArrayList<Member> allMembers) {
        System.out.printf("%-5s%-9s%-11s%11s%13s\n", "ID", "Name", "Join Date", " #Borrowed", "#Requested");
        for(Member m: allMembers) {
            if(m.lastUpdatedDay != SystemDate.getInstance() || m.lastUpdatedDay == null)
                m.updateStatus();
            System.out.printf("%-5s%-9s%-11s%7d%13d\n", m.id, m.name, m.joinDay, m.borrowNum, m.requestNum);
        }
    }

    public void updateStatus() {
        int countBorrow = 0;
        int countRequest = 0;
        for(Reservation reservation : reservations) {
            if(reservation.isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))
                countBorrow++;
            else if(reservation.getStartDay().parseInt() > SystemDate.getInstance().parseInt())
                countRequest++;
        }
        borrowNum = countBorrow;
        requestNum = countRequest;
    }

    public Member(String id, String name) {
        this.id = id;
        this.name = name;
        this.joinDay = SystemDate.getInstance().clone();
        reservations = new ArrayList<Reservation>();
        reservedEquipments = new Hashtable<Reservation, Equipment>();
        lastUpdatedDay = null;
        borrowNum = 0;
        requestNum = 0;
    }

    @Override
    public int compareTo(Member another) {
        return this.id.compareTo(another.id);
    }

    public int compareTo(String id) {
        return this.id.compareTo(id);
    }

    public String getID() {
        return id;
    }

    public String getName() {
        return name;
    }

    public void addReservationRecord(Equipment equipment, Reservation reservation) throws ExRepeatedBorrow{
        for(Reservation current : reservations) {
            if(reservation.isOverlap(current) && reservedEquipments.get(current) == equipment)
                if(reservation.isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))
                    throw new ExRepeatedBorrow();
        }

        reservations.add(reservation);
        reservedEquipments.put(reservation, equipment);
        Collections.sort(reservations);
        if(reservation.isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))
            borrowNum++;
        else if(reservation.getStartDay().parseInt() > SystemDate.getInstance().parseInt())
            requestNum++;
    }

    public void cancelReservation(Reservation reservation) {
        reservations.remove(reservation);
        reservedEquipments.remove(reservation);
        if(reservation.isOverlap(SystemDate.getInstance(), SystemDate.getInstance()))
            borrowNum--;
        else if(reservation.getStartDay().parseInt() > SystemDate.getInstance().parseInt())
            requestNum--;

    }

    @Override
    public String toString() {
        return id + " " + name;
    }

    public String getReservationString() {
        String s = "[" + toString() + "]\n";
        if(reservations.size() == 0) 
            return s + "No record.\n";
        for(Reservation reservation : reservations) {
            s += "- " + reservation.getMemberReservationString() + "\n";
        }
        return s;
    }

}
