package com.listingtodosjava.listingtodosjava.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.List;

@Entity
@Getter
@NoArgsConstructor
public class Assignee {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;

    private String gender;

    private String email;

    @OneToMany(mappedBy = "assignee")
    private List<ToDos> allToDos;

    public Assignee(String name, String gender, String email, List<ToDos> allToDos) {
        this.name = name;
        this.gender = gender;
        this.email = email;
        this.allToDos = allToDos;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setAllToDos(List<ToDos> allToDos) {
        this.allToDos = allToDos;
    }
}
