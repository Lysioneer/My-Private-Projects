package com.listingtodosjava.listingtodosjava.Repositories;

import com.listingtodosjava.listingtodosjava.Models.Assignee;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AssigneeRepository extends JpaRepository<Assignee, Long> {


}
