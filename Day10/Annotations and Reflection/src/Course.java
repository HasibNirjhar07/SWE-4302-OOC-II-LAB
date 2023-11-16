@DevelopmentHistory
public class Course {
    private final String name;
    private final String code;
    private final int credit;

    private  final String type;

    @DevelopmentHistoryWithReviewer
    public Course(String name, String code, int credit, String type) {
        this.name = name;
        this.code = code;
        this.credit = credit;
        this.type =type ;
    }


    public String getName() {
        return name;
    }


    public String getCode() {
        return code;
    }


    public int getCredit() {
        return credit;
    }

    public String getType() {
        return type;
    }
}
