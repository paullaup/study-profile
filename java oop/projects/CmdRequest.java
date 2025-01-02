public class CmdRequest extends RecordedCommand{

    private Member member;
    private Reservation reservation;
    
    @Override
    public void execute(String[] cmdParts) throws ExMemberNotFound, ExInvaildDate, ExEquipmentNotFound, ExBookingFull, ExRepeatedBorrow, ExInvalidDuration{
        member = Club.getInstance().getMember(cmdParts[1]);
        Day starDay = new Day(cmdParts[3]);
        Day lastDay = starDay.clone();
        int durations;
        try {
            durations = Integer.parseInt(cmdParts[4]);
            if(durations < 1)
                throw new ExInvalidDuration("The number of days must be at least 1.");
        } catch (NumberFormatException e) {
            throw new ExInvalidDuration("Please provide an integer for the number of days.");
        }
        lastDay.increment(durations);
        reservation = new Reservation(member, starDay, lastDay);

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
