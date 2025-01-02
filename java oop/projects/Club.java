import java.util.*;

public class Club {

    private static Club instance = null;
    public static Club getInstance() {
        instance = (instance == null)? new Club() : instance;
        return instance;
    }
    
    private ArrayList<Member> allMembers;

    private Club() {
        allMembers = new ArrayList<Member>();
    }

    public void addMember(Member m) throws ExMemberExist{
        for(Member member : allMembers) {
            if(member.compareTo(m) == 0) {
                throw new ExMemberExist(member.getID(), member.getName());
            }
        }
        allMembers.add(m);
        Collections.sort(allMembers);
    }

    public void removeMember(Member m) {
        allMembers.remove(m);
    }

    public void listClubMembers() {
        Member.list(allMembers);
    }

    public Member getMember(String id) throws ExMemberNotFound {
        for(Member member : allMembers) {
            if(member.compareTo(id) == 0) {
                return member;
            }
        }
        throw new ExMemberNotFound();
    }

    public String getMembersStatusString() {
        String s = "";
        for(Member member : allMembers) {
            s += member.getReservationString() + "\n";
        }
        return s;
    }


}
