import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;


public class Main {

	public static void main(String [] args) throws FileNotFoundException {	
		
		Scanner in = new Scanner(System.in);
		
		System.out.print("Please input the file pathname: ");
		String filepathname = in.nextLine();
		
		Scanner inFile = null;
		try {	
			inFile = new Scanner(new File(filepathname));
			//The first command in the file must be to set the system date 
			//(eg. "startNewDay 03-Jan-2024"); and it cannot be undone
			String cmdLine1 = inFile.nextLine();
			String[] cmdLine1Parts = cmdLine1.split(" ");
			System.out.println("\n> "+cmdLine1);
			SystemDate.createTheInstance(cmdLine1Parts[1]);
		} catch(FileNotFoundException e) {
			System.out.println(e.getMessage());
			in.close();
			return;
		} catch(ExInvaildDate e) {
			System.out.println(e.getMessage());
			in.close();
			inFile.close();
			return;
		}
		
		while (inFile.hasNext()) {
			String cmdLine = inFile.nextLine().trim();
			
			//Blank lines exist in data file as separators.  Skip them.
			if (cmdLine.equals("")) continue;  

			System.out.println("\n> "+cmdLine);
			
			//split the words in actionLine => create an array of word strings
			String[] cmdParts = cmdLine.split(" "); 
			
			try {
				if(cmdParts[0].equals("register"))
					if(cmdParts.length != 3)
						throw new ExArgumentInsufficient();
					else
						(new CmdRegister()).execute(cmdParts);	
				else if(cmdParts[0].equals("listMembers"))
					(new CmdListMembers()).execute(cmdParts);
				else if(cmdParts[0].equals("startNewDay"))
					if(cmdParts.length != 2)
						throw new ExArgumentInsufficient();
					else
						(new CmdStartNewDay()).execute(cmdParts);
				else if(cmdParts[0].equalsIgnoreCase("create"))
					if(cmdParts.length != 3)
						throw new ExArgumentInsufficient();
					else 
						(new CmdCreateEquipment()).execute(cmdParts);
				else if(cmdParts[0].equals("listEquipment"))
					(new CmdListEquipment()).execute(cmdParts);
				else if(cmdParts[0].equals("arrive"))
					if(cmdParts.length != 2)
						throw new ExArgumentInsufficient();
					else 
						(new CmdArriveEquipmentSet()).execute(cmdParts);
				else if(cmdParts[0].equals("borrow"))
					if(cmdParts.length != 3 && cmdParts.length != 4)
						throw new ExArgumentInsufficient();
					else
						(new CmdBorrow()).execute(cmdParts);
				else if(cmdParts[0].equals("request"))
					if(cmdParts.length != 5)
						throw new ExArgumentInsufficient();
					else
						(new CmdRequest()).execute(cmdParts);
				else if(cmdParts[0].equals("listEquipmentStatus"))
					(new CmdListEquipmentStatus()).execute(cmdParts);
				else if(cmdParts[0].equals("listMemberStatus"))
					(new CmdListMemberStatus()).execute(cmdParts);
				else if (cmdParts[0].equals("undo"))
					RecordedCommand.undoOneCommand();
				else if (cmdParts[0].equals("redo"))
					RecordedCommand.redoOneCommand();
				else 
					throw new ExUnknownCommand();
			} catch(ExMemberExist e) {
				System.out.println(e.getMessage());
			} catch(ExArgumentInsufficient e) {
				System.out.println(e.getMessage());
			} catch(ExUnknownCommand e) {
				System.out.println(e.getMessage());
				break;
			} catch(ExInvaildDate e) {
				System.out.println(e.getMessage());
			} catch(ExEquipmentExist e) {
				System.out.println(e.getMessage());
			} catch(ExEquipmentNotFound e) {
				System.out.println(e.getMessage());
			} catch (ExMemberNotFound e) {
				System.out.println(e.getMessage());
			} catch (ExBookingFull e) {
				System.out.println(e.getMessage());
			} catch (ExRepeatedBorrow e) {
				System.out.println(e.getMessage());
			} catch (ExInvalidDuration e) {
				System.out.println(e.getMessage());
			}
			
		}

		inFile.close();
		in.close();
	}
}