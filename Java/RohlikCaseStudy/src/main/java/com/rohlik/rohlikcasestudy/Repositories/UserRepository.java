package com.rohlik.rohlikcasestudy.Repositories;

import com.rohlik.rohlikcasestudy.Models.User;
import org.springframework.data.jpa.repository.JpaRepository;

public interface UserRepository extends JpaRepository<User, Long> {


}
