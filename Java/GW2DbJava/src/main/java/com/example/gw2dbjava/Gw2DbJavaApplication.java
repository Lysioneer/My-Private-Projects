package com.example.gw2dbjava;

import com.example.gw2dbjava.Models.Character;
import com.example.gw2dbjava.Models.Location;
import com.example.gw2dbjava.Repositories.LocationRepository;
import lombok.AllArgsConstructor;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.util.List;

@SpringBootApplication
@AllArgsConstructor
public class Gw2DbJavaApplication implements CommandLineRunner {

    private final LocationRepository locationRepository;
    private final List<Character> characters;

    private void defLocs(){
        locationRepository.save(new Location("Queensdale", "Kryta", 1, 15, true, characters));
        locationRepository.save(new Location("Metrica Province", "Maguuma Jungle", 1, 15, true, characters));
        locationRepository.save(new Location("Caledon Forest", "Maguuma Jungle", 1, 15, true, characters));
        locationRepository.save(new Location("Wayfarer Foothills", "Shiverpeaks", 1, 15, true, characters));
        locationRepository.save(new Location("Plains of Ashford", "Ascalon", 1, 15, true, characters));
    }

    @Override
    public void run(String... args) throws Exception {

        //defLocs();      // Uncomment this to insert default locations

    }

    public static void main(String[] args) {
        SpringApplication.run(Gw2DbJavaApplication.class, args);
    }

}
