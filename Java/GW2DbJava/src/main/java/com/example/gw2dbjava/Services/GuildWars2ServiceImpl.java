package com.example.gw2dbjava.Services;

import com.example.gw2dbjava.Models.Character;
import com.example.gw2dbjava.Models.Location;
import com.example.gw2dbjava.Repositories.CharacterRepository;
import com.example.gw2dbjava.Repositories.LocationRepository;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
@AllArgsConstructor
public class GuildWars2ServiceImpl implements GuildWars2Service{

    CharacterRepository characterRepository;
    LocationRepository locationRepository;

    @Override
    public List<String> getSpec(Character character) {

        List<String> specs = new ArrayList<>();
        specs.add("------");

        switch (character.getProfession()){
            case "Warrior":
                specs.add("Berserker");
                specs.add("Spellbreaker");
                return specs;
            case "Guardian":
                specs.add("Dragonhunter");
                specs.add("Firebrand");
                return specs;
            case "Revenant":
                specs.add("Herald");
                specs.add("Renegade");
                return specs;
            case "Thief":
                specs.add("Daredevil");
                specs.add("Deadeye");
                return specs;
            case "Ranger":
                specs.add("Druid");
                specs.add("Soulbeast");
                return specs;
            case "Engineer":
                specs.add("Scrapper");
                specs.add("Holosmith");
                return specs;
            case "Elementalist":
                specs.add("Tempest");
                specs.add("Weaver");
                return specs;
            case "Mesmer":
                specs.add("Chronomancer");
                specs.add("Mirage");
                return specs;
            case "Necromancer":
                specs.add("Reaper");
                specs.add("Scourge");
                return specs;
        }
        return null;
    }

    @Override
    public void createCharacter(Character character) {

        switch(character.getRace()){

            case "Asura":
                character.setLocation(locationRepository.findByName("Metrica Province"));
                break;
            case "Human":
                character.setLocation(locationRepository.findByName("Queensdale"));
                break;
            case "Charr":
                character.setLocation(locationRepository.findByName("Plains of Ashford"));
                break;
            case "Sylvari":
                character.setLocation(locationRepository.findByName("Caledon Forest"));
                break;
            case "Norn":
                character.setLocation(locationRepository.findByName("Wayfarer Foothills"));
                break;
        }

        characterRepository.save(character);
    }

    @Override
    public void addSpec(String spec, Long id) {

        Character character = characterRepository.getById(id);
        character.setSpecialization(spec);

        characterRepository.save(character);
    }

    @Override
    public void deleteChar(Long id) {

        characterRepository.delete(characterRepository.findById(id).get());
    }

    @Override
    public Character updateCharacter(Long id, String name, String gender, int level) {

        Character character = characterRepository.findById(id).get();
        character.setName(name);
        character.setGender(gender);
        character.setLevel(level);

        characterRepository.save(character);
        return character;
    }

    @Override
    public void addLocation(Location location) {

        locationRepository.save(location);
    }

    @Override
    public void deleteLoc(Long id) {

        locationRepository.delete(locationRepository.findById(id).get());
    }
}
