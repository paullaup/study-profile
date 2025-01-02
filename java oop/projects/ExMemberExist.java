public class ExMemberExist extends Exception{
    
    public ExMemberExist() {
        super("Member ID exist.");
    }

    public ExMemberExist(String message) {
        super(message);
    }

    public ExMemberExist(String id, String name) {
        super("Member ID already in use: " + id + " " + name);
    }


}
