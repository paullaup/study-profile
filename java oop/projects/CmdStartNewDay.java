public class CmdStartNewDay extends RecordedCommand{

    String prevString;

    @Override
    public void execute(String[] cmdParts) throws ExInvaildDate{
        prevString = SystemDate.getInstance().toString();
        if(Day.parseInt(prevString) > Day.parseInt(cmdParts[1])) 
            throw new ExInvaildDate("Invalid new day.  The new day has to be later than the current date " + prevString + ".");
        SystemDate.getInstance().set(cmdParts[1]);
        System.out.println("Done.");
        addUndoCommand(this);
        clearRedoList();
        Equipment.updateEquipmentsStatus();
    }

    @Override
    public void undoMe() {
        try {
            String temp = SystemDate.getInstance().toString();
            SystemDate.getInstance().set(prevString);
            prevString = temp;
            addRedoCommand(this);
            Equipment.updateEquipmentsStatus();
        } catch(Exception e) {
            //fullfil checked exception, suppose command in undoList pass the error checking
        }
    }

    @Override
    public void redoMe() {
        try {
            String temp = SystemDate.getInstance().toString();
            SystemDate.getInstance().set(prevString);
            prevString = temp;
            addUndoCommand(this);
            Equipment.updateEquipmentsStatus();
        } catch(Exception e) {
            //fullfil checked exception, suppose command in redoList pass the error checking
        }
    }
    
}
