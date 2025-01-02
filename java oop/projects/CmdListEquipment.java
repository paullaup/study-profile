public class CmdListEquipment implements Command{
    
    @Override
    public void execute(String[] cmdParts) {
        Equipment.listEquipment();
    }

}
