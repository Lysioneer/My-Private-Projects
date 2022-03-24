package com.listingtodosjava.listingtodosjava.Controllers;

import com.listingtodosjava.listingtodosjava.Models.ToDos;
import com.listingtodosjava.listingtodosjava.Repositories.ToDoRepository;
import com.listingtodosjava.listingtodosjava.Services.AssigneeService;
import com.listingtodosjava.listingtodosjava.Services.ToDoService;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
@AllArgsConstructor
@RequestMapping(path = "/")
public class ToDoController {

    private ToDoService toDoService;
    private AssigneeService assigneeService;
    private ToDoRepository toDoRepository;

    @GetMapping()
    public ModelAndView ListToDos(){

        ModelAndView mav = new ModelAndView("ToDo/ToDoList");

        mav.addObject("todos", toDoRepository.findAll());

        return mav;
    }

    @GetMapping("/ListUndone")
    public String ListUndone(){

        return "ToDoList";
    }

    @GetMapping("/AddToDo")
    public String Add(){

        return "AddToDo";
    }

    @PostMapping("/AddedToDo")
    public String AddToDo(String title, String description, Boolean urgent, Boolean done, Long assigneeId){

        return "ToDoList";
    }

    @GetMapping("/{id}/remove")
    public String RemoveToDo(Long id){

        return "ToDoList";
    }

    @GetMapping("/{id}/edit")
    public String EditToDo(Long id){

        return "EditToDo";
    }

    @PostMapping("/{id}/edited")
    public String EditedToDo(ToDos toDo, Long assigneeId){

        return "ToDoList";
    }

    @PostMapping("/search")
    public String Search(String searchInput){

        return "ToDoList";
    }

}
