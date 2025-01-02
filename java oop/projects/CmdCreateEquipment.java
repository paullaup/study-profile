public class CmdCreateEquipment extends RecordedCommand{

    private Equipment equipment;
    
    @Override
    public void execute(String[] cmdParts) throws ExEquipmentExist{
        equipment = new Equipment(cmdParts[1], cmdParts[2]);
        Equipment.create(equipment);
        RecordedCommand.addUndoCommand(this);
        System.out.println("Done.");
        clearRedoList();
    }

    @Override
    public void undoMe() {
        try{
            Equipment.remove(equipment);
            addRedoCommand(this);
        } catch(ExEquipmentNotFound e) {
            //suppose command in undoList is execute once
        }
    }

    @Override
    public void redoMe(){
        try {
            Equipment.create(equipment);
            addUndoCommand(this);
        } catch(ExEquipmentExist e) {
            //suppose command in redoList pass the error checking
            //redoList will be clear if a new Equipment is created
        }
    }

}
