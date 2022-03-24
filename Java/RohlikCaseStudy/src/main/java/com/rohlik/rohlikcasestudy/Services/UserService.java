package com.rohlik.rohlikcasestudy.Services;

import com.rohlik.rohlikcasestudy.Models.User;

import java.time.LocalDateTime;
import java.util.List;

public interface UserService {

    public void addUser(String name, String surname, String email, Integer phoneNumber);

    public void changeStatus(Long id);

    public List<User> searchUsers(String searchInput);
}
