package com.example.gw2dbjava.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.List;

@Entity
@NoArgsConstructor
@Getter
public class Location {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;

    private String region;

    private int minLevel;

    private int maxLevel;

    private Boolean startingLoc;

    @OneToMany(mappedBy = "locationId")
    private List<Character> characters;

    public Location(String name, String region, int minLevel, int maxLevel, Boolean startingLoc, List<Character> characters) {
        this.name = name;
        this.region = region;
        this.minLevel = minLevel;
        this.maxLevel = maxLevel;
        this.startingLoc = startingLoc;
        this.characters = characters;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setRegion(String region) {
        this.region = region;
    }

    public void setMinLevel(int minLevel) {
        this.minLevel = minLevel;
    }

    public void setMaxLevel(int maxLevel) {
        this.maxLevel = maxLevel;
    }

    public void setStartingLoc(Boolean startingLoc) {
        this.startingLoc = startingLoc;
    }

    public void setCharacters(List<Character> characters) {
        this.characters = characters;
    }
}
