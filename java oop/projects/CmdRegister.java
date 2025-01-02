public class CmdRegister extends RecordedCommand {

    private Member m;

    @Override
    public void execute(String[] cmdParts) throws ExMemberExist{
        m = new Member(cmdParts[1], cmdParts[2]);
        Club.getInstance().addMember(m);
        System.out.println("Done.");
        addUndoCommand(this);
        clearRedoList();
    }

    @Override
    public void undoMe() {
        Club.getInstance().removeMember(m);
        addRedoCommand(this);
    }

    @Override
    public void redoMe() {
        try {
            Club.getInstance().addMember(m);
        } catch(ExMemberExist e) {
            // just to fullfil compiler, suppose command in redoList pass the error checking
        }
        addUndoCommand(this);
    }

}