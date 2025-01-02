public class CmdListEquipmentStatus implements Command{
    
    @Override
    public void execute(String[] cmdParts) {
        System.out.println(Equipment.getEquipmentStatusString());
    }

}
