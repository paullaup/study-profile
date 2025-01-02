import java.util.*;

public class EquipmentSet implements Comparable<EquipmentSet>{
    
    private boolean isAvailable;
    private ArrayList<Reservation> reservations; 
    private Reservation activeReservation;
    private Equipment equipment;
    private String label;

    public EquipmentSet() {
        isAvailable = true;
        reservations = new ArrayList<Reservation>();
    }

    public void setEquipmentSet(Equipment equipment, String label) {
        isAvailable = true;
        reservations = new ArrayList<Reservation>();
        this.equipment = equipment;
        this.label = label;
    }

    public void clear() {
        equipment.removeSet(this);
    }

    public void add() {
        equipment.addSet(this);
    }

    public boolean makeReservation(Reservation newReservation) throws ExRepeatedBorrow{
        if(!isAvailable && newReservation.isOverlap(activeReservation))
            return false;
        for(Reservation reservation : reservations) {
            if(reservation.isOverlap(newReservation))
                return false;
        }
        submitReservation(newReservation);
        return true;
    }

    public void submitReservation(Reservation reservation) throws ExRepeatedBorrow {
        reservation.getMember().addReservationRecord(equipment, reservation);
        reservations.add(reservation);
        if(reservation.isOverlap(SystemDate.getInstance(), SystemDate.getInstance())) {
            isAvailable = false;
            activeReservation = reservation;
        }
        Collections.sort(reservations);
    }

    public void cancelReservation(Reservation reservation) {
        if(reservation == activeReservation)
            isAvailable = true;
        reservations.remove(reservation);
    }

    public void updateStatus() {
        Day today = SystemDate.getInstance().clone();
        if(isAvailable || !activeReservation.isOverlap(today, today)) {
            isAvailable = true;
            activeReservation = null;
            for(Reservation reservation : reservations) {
                if(reservation.isOverlap(today, today)) {
                     isAvailable = false;
                     activeReservation = reservation;
                     break;
                }
            }
        }


    }

    @Override
    public String toString() {
        return String.format("%s (%s)", label, equipment.getName());
    }

    public String getLoanDetails() {
        if(isAvailable) 
            return "";
        return String.format("%s(%s)", label, activeReservation.getMember().getID());
    }

    public String getStatusString() {
        String s = "  " + label + "\n";
        s += "    " + "Current status: ";
        if(isAvailable)
            s += "Available";
        else
            s += activeReservation.getEquipmentStatusString();
        String requests = "";
        for(Reservation reservation : reservations) {
            if(!reservation.isOverlap(SystemDate.getInstance(), SystemDate.getInstance()) && reservation.getStartDay().parseInt() > SystemDate.getInstance().parseInt())
                requests += reservation.getPeriodString() + ", ";
        }
        if(!requests.equals(""))
            s += "\n    Requested period(s): " + requests.substring(0, requests.length() - 2);
        return s;
    }

    @Override
    public int compareTo(EquipmentSet set) {
        return this.label.compareTo(set.label); 
    }

}
