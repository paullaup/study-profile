public class ExRepeatedBorrow extends Exception{
    
    public ExRepeatedBorrow() {
        //super("The member is currently borrowing a set of this equipment. He/she cannot borrow one more at the same time.");
        super("The period overlaps with a current period that the member borrows / requests the equipment.");
    }

}
