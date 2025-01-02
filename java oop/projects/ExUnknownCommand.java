public class ExUnknownCommand extends Exception {
    
    public ExUnknownCommand() {
        super("Unknown command - ignored.");
    }

    public ExUnknownCommand(String message) {
        super(message);
    }

}
