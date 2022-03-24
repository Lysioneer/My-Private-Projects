package com.listingtodosjava.listingtodosjava.Services;

import com.listingtodosjava.listingtodosjava.Models.ToDos;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface ToDoService {

    public List<ToDos> ListUndone();

    public void AddToDo(String title, String Description, Boolean Urgent, Long AssigneeId);

    public void RemoveToDo(Long Id);

    public void EditToDo(ToDos ToDo, Long AssigneeId);

    public List<ToDos> SearchToDos(String SearchInput);
}
