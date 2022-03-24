package com.rohlik.rohlikcasestudy.Services;

import com.google.common.primitives.Ints;
import com.rohlik.rohlikcasestudy.Models.User;
import com.rohlik.rohlikcasestudy.Repositories.UserRepository;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
@AllArgsConstructor
public class UserServiceImpl implements UserService{

    UserRepository userRepository;

    @Override
    public void addUser(String name, String surname, String email, Integer phoneNumber) {

        User user = new User();
        user.setName(name);
        user.setSurname(surname);
        user.setEmail(email);
        user.setPhoneNumber(phoneNumber);
        user.setActive(false);
        user.setCreation(LocalDateTime.now());

        userRepository.save(user);
    }

    @Override
    public void changeStatus(Long id) {

        User user = userRepository.findById(id).get();

        if(user.getActive() == true){
            user.setActive(false);
        } else {
            user.setActive(true);
        }
        userRepository.save(user);
    }

    @Override
    public List<User> searchUsers(String searchInput) {

        searchInput = searchInput.toLowerCase();

        Long srchInpNum = Ints.tryParse(searchInput).longValue();

        if (srchInpNum != null){

            List<User> users = userRepository
                            .findAll()
                            .stream().filter((User) -> User.getId() == srchInpNum)
                            .collect(Collectors.toList());

            return users;
        } else if (searchInput.equals("activate") || searchInput.equals("deactivate")) {

            Boolean status = searchInput.equals("activate")?(true):(false);

            List<User> users = userRepository
                    .findAll()
                    .stream().filter((User) -> User.getActive() == status)
                    .collect(Collectors.toList());
        } else {

            String finalSearchInput = searchInput;
            List<User> users = userRepository
                    .findAll()
                    .stream().filter((User) -> User.getName().toLowerCase().equals(finalSearchInput)
                            || User.getSurname().toLowerCase().equals(finalSearchInput))
                    .collect(Collectors.toList());

            return users;
        }
        return null;
    }
}
