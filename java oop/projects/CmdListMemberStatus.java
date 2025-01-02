public class CmdListMemberStatus implements Command{
    
    @Override
    public void execute(String[] cmdParts) {
        System.out.println(Club.getInstance().getMembersStatusString());
    }

}
