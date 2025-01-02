public class CmdBorrow extends RecordedCommand {

    private Member m;
    private Reservation reservation;
    
    @Override
    public void execute(String[] cmdParts) throws ExMemberNotFound, ExEquipmentNotFound, ExBookingFull, ExRepeatedBorrow, ExInvalidDuration{
        int durations;
        try {
            if(cmdParts.length == 3)
                durations = 7;
            else 
                durations = Integer.parseInt(cmdParts[3]);
            if(durations < 1)
                throw new ExInvalidDuration("The number of days must be at least 1.");
        } catch(NumberFormatException e) {
            throw new ExInvalidDuration("Please provide an integer for the number of days.");
        }
        m = Club.getInstance().getMember(cmdParts[1]);
        Day startDay = SystemDate.getInstance().clone();
        Day lastDay = SystemDate.getInstance().clone();
        lastDay.increment(durations);
        reservation = new Reservation(m, startDay, lastDay);

        Equipment.makeReservation(cmdParts[2], reservation);

        System.out.printf(reservation.toString() + "\n");
        System.out.println("Done.");
        addUndoCommand(this);
        clearRedoList();   
    }

    @Override
    public void undoMe() {
        reservation.remove();
        addRedoCommand(this);
    }

    @Override
    public void redoMe() {
        try {
            reservation.reAdd();
            addUndoCommand(this);
        } catch(ExRepeatedBorrow e) {
            //suppose command in redoList pass error checking
        }
    }


}
