public class ExEquipmentNotFound extends Exception {

    public ExEquipmentNotFound() {
        super("Equipment record not found.");
    }

    public ExEquipmentNotFound(String code) {
        super("Missing record for Equipment " + code + ".  Cannot mark this item arrival.");
    }

}
