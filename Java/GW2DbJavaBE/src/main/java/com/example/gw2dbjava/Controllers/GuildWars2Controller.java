package com.example.gw2dbjava.Controllers;

import com.example.gw2dbjava.Models.Character;
import com.example.gw2dbjava.Models.Location;
import com.example.gw2dbjava.Models.Message;
import com.example.gw2dbjava.Models.SpecDTO;
import com.example.gw2dbjava.Repositories.CharacterRepository;
import com.example.gw2dbjava.Repositories.LocationRepository;
import com.example.gw2dbjava.Services.GuildWars2Service;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@AllArgsConstructor
@RequestMapping(path = "/")
public class GuildWars2Controller {

    GuildWars2Service guildWars2Service;
    CharacterRepository characterRepository;
    LocationRepository locationRepository;

    @GetMapping()
    public ResponseEntity ListCharacters(){

        List<Character> characters = characterRepository.findAll();

        return ResponseEntity.status(HttpStatus.OK).body(characters);
    }
    @PostMapping("/characterAdd")
    public ResponseEntity CharacterAdd(@RequestBody Character character){

        guildWars2Service.createCharacter(character);
        List<String> specializations = guildWars2Service.getSpec(character);

        return ResponseEntity.status(HttpStatus.OK).body(character);
    }
    @PostMapping("/specOption")
    public ResponseEntity SpecOption(@RequestBody SpecDTO specDTO){

        guildWars2Service.addSpec(specDTO.getSpec(), specDTO.getId());

        return ResponseEntity.status(HttpStatus.OK).body(new Message("Specialization added."));
    }
    @GetMapping("/{id}/editCharacter")
    public ResponseEntity EditCHaracter(@PathVariable(name = "id") Long id){

        Character character = characterRepository.findById(id).get();

        return ResponseEntity.status(HttpStatus.OK).body(character);
    }
    @GetMapping("/{id}/deleteCharacter")
    public ResponseEntity DeleteCharacter(@PathVariable(name = "id") Long id){

        guildWars2Service.deleteChar(id);

        return ResponseEntity.status(HttpStatus.OK).body(new Message("Character successfully deleted."));
    }

    @PostMapping("/editCharacter")
    public ResponseEntity EditCharacter(@RequestBody Long id, @RequestBody String name,
                                        @RequestBody String gender, @RequestBody int level){

        Character character = guildWars2Service.updateCharacter(id, name, gender, level);

        return ResponseEntity.status(HttpStatus.OK).body(character);
    }
    @GetMapping("/listLocation")
    public ResponseEntity ListLocations(){

        List<Location> locations = locationRepository.findAll();

        return ResponseEntity.status(HttpStatus.OK).body(locations);
    }
    @PostMapping("/locationAdd")
    public ResponseEntity LocationAdd(@RequestBody Location location){

        guildWars2Service.addLocation(location);

        return ResponseEntity.status(HttpStatus.OK).body(new Message("New location added."));
    }
    @GetMapping("/{id}/deleteLocation")
    public ResponseEntity DeleteLocation(@PathVariable(name = "id") Long id){

        guildWars2Service.deleteLoc(id);

        return ResponseEntity.status(HttpStatus.OK).body(new Message("Location deleted."));
    }

}
