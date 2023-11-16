import java.lang.annotation.*;

@Documented
@Retention(RetentionPolicy.RUNTIME)
@Target({ElementType.CONSTRUCTOR,ElementType.METHOD})
public @interface DevelopmentHistoryWithReviewer {
    double version() default 1.0;

    String developer() default "Nirjhar007";

    String Tester() default "Nirjhar";

    String[] reviewers() default {"Nirjhar","Shazid","Rakib"};

}
