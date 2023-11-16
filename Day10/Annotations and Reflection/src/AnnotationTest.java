import org.junit.Assert;
import org.junit.Test;

import java.lang.reflect.Constructor;
import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.List;


public class AnnotationTest {
    @Test
    public void TypeAnnotationTest(){
     boolean isAnnotationPresent = Faculty.class.isAnnotationPresent(DevelopmentHistory.class);
        Assert.assertTrue(isAnnotationPresent);
    }

    @Test
    public void ConstructorAnnotationTest(){
        Object faculty=new Faculty("Nirjhar","Lecturer",50000.0);
        Constructor[] constructors = faculty.getClass().getDeclaredConstructors();
        List<String> constructorNames=new ArrayList<>();
        for (Constructor constructor : constructors) {
            boolean isAnnotationPresent = constructor.isAnnotationPresent(DevelopmentHistoryWithReviewer.class);
            if(isAnnotationPresent){
                constructorNames.add(constructor.getName());
            }

        }
        Assert.assertEquals(2,constructorNames.size());
        Assert.assertTrue(constructorNames.contains("Faculty"));
    }

    @Test
    public void MethodAnnotationTest(){
        Object faculty=new Faculty("Nirjhar","Lecturer",50000.0);
        Method[] methods = faculty.getClass().getDeclaredMethods();
        List<String> methodNames=new ArrayList<>();
        for (Method method : methods) {
            boolean isAnnotationPresent = method.isAnnotationPresent(DevelopmentHistoryWithReviewer.class);
            if(isAnnotationPresent){
                methodNames.add(method.getName());
            }

        }
        Assert.assertEquals(2,methodNames.size());
        Assert.assertTrue(methodNames.contains("teach"));
        Assert.assertTrue(methodNames.contains("research"));
    }
}
