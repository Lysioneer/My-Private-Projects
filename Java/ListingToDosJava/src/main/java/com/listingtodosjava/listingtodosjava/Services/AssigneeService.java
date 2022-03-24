package com.listingtodosjava.listingtodosjava.Services;

import com.listingtodosjava.listingtodosjava.Models.Assignee;
import org.springframework.stereotype.Service;

@Service
public interface AssigneeService {

    public void AddAssignee(Assignee Assignee);

    public void RemoveAssignee(Long Id);

    public void EditAssignee(String Name, String Email, Long Id);
}
