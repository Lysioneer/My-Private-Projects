package com.example.gw2dbjava.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;

import javax.persistence.*;

@Entity
@NoArgsConstructor
@Getter
public class Character {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String gender;

    private String race;

    private String name;

    private int level;

    private String profession;

    private String specialization;

    @ManyToOne
    private Location locationId;

    public Character(String gender, String race, String name, int level, String profession, String specialization, Location locationId) {
        this.gender = gender;
        this.race = race;
        this.name = name;
        this.level = level;
        this.profession = profession;
        this.specialization = specialization;
        this.locationId = locationId;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public void setRace(String race) {
        this.race = race;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setLevel(int level) {
        this.level = level;
    }

    public void setProfession(String profession) {
        this.profession = profession;
    }

    public void setSpecialization(String specialization) {
        this.specialization = specialization;
    }

    public void setLocation(Location locationId) {
        this.locationId = locationId;
    }
}
