package com.listingtodosjava.listingtodosjava.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;

import javax.persistence.*;

@Entity
@Getter
@NoArgsConstructor
public class ToDos {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String title;

    private String description;

    private Boolean urgent;

    private Boolean done;

    @ManyToOne
    @JoinColumn(name = "assignee_id")
    private Assignee assignee;

    public ToDos(String title, String description, Boolean urgent, Boolean done, Assignee assignee) {
        this.title = title;
        this.description = description;
        this.urgent = urgent;
        this.done = done;
        this.assignee = assignee;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public void setUrgent(Boolean urgent) {
        this.urgent = urgent;
    }

    public void setDone(Boolean done) {
        this.done = done;
    }

    public void setAssignee(Assignee assignee) {
        this.assignee = assignee;
    }
}
