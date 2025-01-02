import java.util.ArrayList;
import java.util.Collections;

public class Equipment implements Comparable<Equipment>{

    private static ArrayList<Equipment> equipmentList = new ArrayList<Equipment>();

    public static void create(Equipment newEquipment) throws ExEquipmentExist {
        for(Equipment equipment : equipmentList) {
            if(equipment.compareTo(newEquipment) == 0)
                throw new ExEquipmentExist(equipment.code, equipment.name);
        }
        equipmentList.add(newEquipment);
        Collections.sort(equipmentList);
    }

    public static void remove(Equipment newEquipment) throws ExEquipmentNotFound{
        for(int i = 0; i < equipmentList.size(); i++) {
            if(equipmentList.get(i).compareTo(newEquipment) == 0) {
                equipmentList.remove(i);
                return;
            }
        }
        throw new ExEquipmentNotFound(newEquipment.code);
    }

    public static EquipmentSet arrive(String code, EquipmentSet set) throws ExEquipmentNotFound {
        for(int i = 0; i < equipmentList.size(); i++) {
            if(equipmentList.get(i).compareTo(code) == 0) {
                set.setEquipmentSet(equipmentList.get(i), String.format("%s_%d", equipmentList.get(i).code, equipmentList.get(i).setList.size() + 1));
                equipmentList.get(i).addSet(set);
                return set;
            }
        }
        throw new ExEquipmentNotFound(code);
    }

    public static void listEquipment() {
        System.out.println("Code Name              #sets");
        for(Equipment equipment : equipmentList) {
            System.out.println(equipment);
        }
    }

    public static void makeReservation(String code, Reservation reservation) throws ExEquipmentNotFound, ExBookingFull, ExRepeatedBorrow{
        for(Equipment equipment : equipmentList) {
            if(equipment.compareTo(code) == 0) {
                equipment.makeReservation(reservation);
                return;
            }
        }
        throw new ExEquipmentNotFound();
    }

    public static void updateEquipmentsStatus() {
        for(Equipment equipment : equipmentList)
            equipment.updateStatus();
    }

    public static String getEquipmentStatusString() {
        String s = "";
        for(Equipment equipment : equipmentList) {
            s += equipment.getStatusString();
        }
        return s;
    }
    
    private String code;
    private String name;
    private ArrayList<EquipmentSet> setList;

    @Override
    public int compareTo(Equipment set) {
        return this.code.compareTo(set.code);
    }

    public int compareTo(String code) {
        return this.code.compareTo(code);
    }

    public Equipment(String code, String name) {
        this.code = code;
        this.name = name;
        setList = new ArrayList<EquipmentSet>();
    }

    public String toString() {
        String s = String.format("%-5s%-20s%-5d", code, name, setList.size());
        String borrowedString = "";
        boolean empty = true;
        for(int i = 0; i < setList.size(); i++) {
            String temp = setList.get(i).getLoanDetails();
            if(!temp.equals("")) {
                borrowedString += temp + ", ";
                empty = false;
            }
        }
        if(empty)
            return s;
        borrowedString = borrowedString.substring(0, borrowedString.length() - 2);
        return s + "(Borrowed set(s): " + borrowedString + ")";
    }

    public void addSet(EquipmentSet set) {
        setList.add(set);
    }

    public void removeSet(EquipmentSet set) {
        setList.remove(set);
    }

    public void makeReservation(Reservation reservation) throws ExBookingFull, ExRepeatedBorrow{
        for(EquipmentSet set : setList) {
            reservation.setEquipmentSet(set);
            if(set.makeReservation(reservation))
                return;
        }
        throw new ExBookingFull();
    }

    public void updateStatus() {
        for(EquipmentSet set : setList)
            set.updateStatus();
    }

    public String getName() {
        return name;
    }

    public String getStatusString() {
        String s = String.format("[%s %s]\n", code, name);
        if(setList.size() == 0) 
            return s + "  " + "We do not have any sets for this equipment.\n\n";
        for(EquipmentSet set : setList) {
            s += set.getStatusString() + "\n";
        }
        return s + "\n";

    }

}
