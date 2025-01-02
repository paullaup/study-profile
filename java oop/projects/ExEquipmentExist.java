public class ExEquipmentExist extends Exception{

    public ExEquipmentExist(String code, String name) {
        super("Equipment code already in use: " + code + " " + name);
    }

}
