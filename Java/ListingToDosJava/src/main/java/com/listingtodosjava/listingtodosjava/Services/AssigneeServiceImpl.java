package com.listingtodosjava.listingtodosjava.Services;

import com.listingtodosjava.listingtodosjava.Models.Assignee;
import com.listingtodosjava.listingtodosjava.Repositories.AssigneeRepository;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@AllArgsConstructor
public class AssigneeServiceImpl implements AssigneeService{

    private AssigneeRepository assigneeRepository;

    @Override
    public void AddAssignee(Assignee Assignee) {

    }

    @Override
    public void RemoveAssignee(Long Id) {

    }

    @Override
    public void EditAssignee(String Name, String Email, Long Id) {

    }
}
