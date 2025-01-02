public class CmdArriveEquipmentSet extends RecordedCommand {
    
    private EquipmentSet set;

    @Override
    public void execute(String[] cmdParts) throws ExEquipmentNotFound{
        set = new EquipmentSet();
        Equipment.arrive(cmdParts[1], set);
        addUndoCommand(this);
        System.out.println("Done.");
        clearRedoList();
    }

    @Override
    public void undoMe() {
        set.clear();
        addRedoCommand(this);
    }

    @Override
    public void redoMe() {
        set.add();
        addUndoCommand(this);
    }


}
