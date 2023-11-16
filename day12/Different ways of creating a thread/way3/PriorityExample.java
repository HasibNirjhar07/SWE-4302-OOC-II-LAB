package way3;

public class PriorityExample implements Runnable {
    private String name;

    public PriorityExample(String name) {
        this.name = name;
    }

    @Override
    public void run() {
        for (int i = 1; i <= 4; i++) {
            System.out.println("Task: " + name + ", Iteration: " + i);
            try {
                Thread.sleep(2000);
            } catch (InterruptedException e) {
                System.out.println("Thread interrupted: " + e.getMessage());
            }
        }
    }
}

