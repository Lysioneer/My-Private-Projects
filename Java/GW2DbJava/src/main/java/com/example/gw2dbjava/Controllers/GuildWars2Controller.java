package com.example.gw2dbjava.Controllers;

import com.example.gw2dbjava.Models.Character;
import com.example.gw2dbjava.Models.Location;
import com.example.gw2dbjava.Repositories.CharacterRepository;
import com.example.gw2dbjava.Repositories.LocationRepository;
import com.example.gw2dbjava.Services.GuildWars2Service;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

@Controller
@AllArgsConstructor
@RequestMapping(path = "/")
public class GuildWars2Controller {

    GuildWars2Service guildWars2Service;
    CharacterRepository characterRepository;
    LocationRepository locationRepository;

    @GetMapping()
    public String ListCharacters(Model model){

        List<Character> characters = characterRepository.findAll();
        model.addAttribute("characters", characters);

        return "ListCharacters";
    }
    @GetMapping("/addCharacter")
    public String AddCharacter(){

        return "AddCharacter";
    }
    @PostMapping("/characterAdd")
    public String CharacterAdd(Character character, Model model){

        guildWars2Service.createCharacter(character);
        List<String> specializations = guildWars2Service.getSpec(character);

        model.addAttribute("specs", specializations);
        model.addAttribute("character", character);

        return "SpecOption";
    }
    @PostMapping("/specOption")
    public String SpecOption(String spec, Long id){

        guildWars2Service.addSpec(spec, id);

        return "redirect:/";
    }
    @GetMapping("/{id}/editCharacter")
    public String EditCHaracter(@PathVariable(name = "id") Long id, Model model){

        Character character = characterRepository.findById(id).get();

        model.addAttribute("character", character);

        return "EditCharacter";
    }
    @GetMapping("/{id}/deleteCharacter")
    public String DeleteCharacter(@PathVariable(name = "id") Long id){

        guildWars2Service.deleteChar(id);

        return "redirect:/";
    }

    @PostMapping("/editCharacter")
    public String EditCharacter(Long id, String name, String gender, int level, Model model){

        Character character = guildWars2Service.updateCharacter(id, name, gender, level);
        List<String> specializations = guildWars2Service.getSpec(character);

        model.addAttribute("specs", specializations);
        model.addAttribute("character", character);

        return "SpecOption";
    }
    @GetMapping("/listLocation")
    public String ListLocations(Model model){

        List<Location> locations = locationRepository.findAll();
        model.addAttribute("locations", locations);

        return "ListLocations";
    }
    @GetMapping("/addLocation")
    public String AddLocation(){

        return "AddLocation";
    }
    @PostMapping("/locationAdd")
    public String LocationAdd(Location location){

        guildWars2Service.addLocation(location);

        return "redirect:/listLocation";
    }
    @GetMapping("/{id}/deleteLocation")
    public String DeleteLocation(@PathVariable(name = "id") Long id){

        guildWars2Service.deleteLoc(id);

        return "redirect:/listLocation";
    }

}
