package com.rohlik.rohlikcasestudy.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.time.LocalDateTime;

@Entity
@Getter
@NoArgsConstructor
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;

    private String surname;

    private Boolean active;

    private String email;

    private Integer phoneNumber;

    private LocalDateTime creation;

    public User(String name, String surname, Boolean active, String email, Integer phoneNumber, LocalDateTime creation) {
        this.name = name;
        this.surname = surname;
        this.active = active;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.creation = creation;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setPhoneNumber(Integer phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public void setCreation(LocalDateTime creation) {
        this.creation = creation;
    }
}
