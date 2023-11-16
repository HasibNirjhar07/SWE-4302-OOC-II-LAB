//package threading.examplesOfCreating;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;



public class ExecutorServeThread {
    public static void main(String[] args) {
        int numberOfTasks = 5;
        ExecutorService executorService = Executors.newFixedThreadPool(3);

        for (int i = 0; i < numberOfTasks; i++) {
            Task task = new Task(i + 1);
            executorService.submit(task);
        }

        executorService.shutdown();
    }
}

class Task implements Runnable {
    private int taskId;

    public Task(int taskId) {
        this.taskId = taskId;
    }

    public void run() {
        System.out.println("Task ID: " + taskId + ", Thread: " + Thread.currentThread().getName());
    }
}
