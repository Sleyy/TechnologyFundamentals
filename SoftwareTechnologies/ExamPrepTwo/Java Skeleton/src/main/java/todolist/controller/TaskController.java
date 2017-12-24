package todolist.controller;

import javassist.NotFoundException;
import org.codehaus.groovy.control.messages.ExceptionMessage;
import org.omg.IOP.ExceptionDetailMessage;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import todolist.bindingModel.TaskBindingModel;
import todolist.entity.Task;
import todolist.repository.TaskRepository;

import java.util.List;

@Controller
public class TaskController {

    @Autowired
    private  TaskRepository taskRepository;



    @GetMapping("/")
    public String index(Model model) {

        List<Task> tasks = this.taskRepository.findAll();

        model.addAttribute("tasks", tasks);
        model.addAttribute("view", "task/index");

        return "base-layout";
    }

    @GetMapping("/create")
    public String create(Model model) {

        model.addAttribute("view","task/create");
        return "base-layout";
    }

    @PostMapping("/create")
    public String createProcess(Model model, TaskBindingModel taskBindingModel) {

        Task currentTask = new Task();

        currentTask.setTitle(taskBindingModel.getTitle());
        currentTask.setComments(taskBindingModel.getComments());


        this.taskRepository.saveAndFlush(currentTask);

       return "redirect:/";
    }

    @GetMapping("/delete/{id}")
    public String delete(Model model, @PathVariable int id) {

        if (!this.taskRepository.exists(id)){
            return "NotFoundException";
        }

        Task currentTask = this.taskRepository.findOne(id);

        model.addAttribute("task",currentTask);
        model.addAttribute("view","task/delete");

        return "base-layout";
    }

    @PostMapping("/delete/{id}")
    public String deleteProcess(Model model, @PathVariable int id) {
        if (!this.taskRepository.exists(id)){
            return "NotFoundException";
        }

        Task currentTask = this.taskRepository.findOne(id);

        this.taskRepository.delete(currentTask);


        return "redirect:/";
    }
}
