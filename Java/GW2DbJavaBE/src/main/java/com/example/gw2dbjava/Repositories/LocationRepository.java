package com.example.gw2dbjava.Repositories;

import com.example.gw2dbjava.Models.Location;
import org.springframework.data.jpa.repository.JpaRepository;

public interface LocationRepository extends JpaRepository<Location, Long> {

    public Location findByName(String name);

}
