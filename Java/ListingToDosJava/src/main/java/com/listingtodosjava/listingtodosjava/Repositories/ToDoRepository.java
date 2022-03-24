package com.listingtodosjava.listingtodosjava.Repositories;

import com.listingtodosjava.listingtodosjava.Models.ToDos;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface ToDoRepository extends JpaRepository<ToDos, Long> {


}
