package com.example.gw2dbjava.Services;

import com.example.gw2dbjava.Models.Character;
import com.example.gw2dbjava.Models.Location;

import java.util.List;

public interface GuildWars2Service {

    public void createCharacter(Character character);

    public List<String> getSpec(Character character);

    public void addSpec(String spec, Long id);

    public void deleteChar(Long id);

    public Character updateCharacter(Long id, String name, String gender, int level);

    public void addLocation(Location location);

    public void deleteLoc(Long id);

}
