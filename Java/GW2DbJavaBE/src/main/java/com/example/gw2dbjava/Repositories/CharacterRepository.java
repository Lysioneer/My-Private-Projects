package com.example.gw2dbjava.Repositories;

import com.example.gw2dbjava.Models.Character;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CharacterRepository extends JpaRepository<Character, Long> {



}
