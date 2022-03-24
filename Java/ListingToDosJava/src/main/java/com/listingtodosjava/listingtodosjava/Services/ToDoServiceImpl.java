package com.listingtodosjava.listingtodosjava.Services;

import com.listingtodosjava.listingtodosjava.Models.ToDos;
import com.listingtodosjava.listingtodosjava.Repositories.ToDoRepository;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@AllArgsConstructor
public class ToDoServiceImpl implements ToDoService{

    private ToDoRepository toDoRepository;

    //private AssigneeService assigneeService;

    @Override
    public List<ToDos> ListUndone() {
        return null;
    }

    @Override
    public void AddToDo(String title, String Description, Boolean Urgent, Long AssigneeId) {

    }

    @Override
    public void RemoveToDo(Long Id) {

    }

    @Override
    public void EditToDo(ToDos ToDo, Long AssigneeId) {

    }

    @Override
    public List<ToDos> SearchToDos(String SearchInput) {
        return null;
    }
}
