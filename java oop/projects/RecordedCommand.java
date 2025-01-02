import java.util.ArrayList;

public abstract class RecordedCommand implements Command {
    
    private static ArrayList<RecordedCommand> undoList = new ArrayList<RecordedCommand>();
    private static ArrayList<RecordedCommand> redoList = new ArrayList<RecordedCommand>();

    public abstract void undoMe();
    public abstract void redoMe();
    

    protected static void addUndoCommand(RecordedCommand command) {
        undoList.add(command);
    }

    protected static void addRedoCommand(RecordedCommand command) {
        redoList.add(command);  
    }

    protected static void clearRedoList() {
        redoList.clear();
    }

    public static void undoOneCommand() {
        if(!undoList.isEmpty())
            undoList.remove(undoList.size() - 1).undoMe();
        else
            System.out.println("Nothing to undo.");
    }

    public static void redoOneCommand() {
        if(!redoList.isEmpty())
            redoList.remove(redoList.size() - 1).redoMe();
        else
            System.out.println("Nothing to redo.");
    }

}