package com.rohlik.rohlikcasestudy.Controllers;

import com.rohlik.rohlikcasestudy.Models.User;
import com.rohlik.rohlikcasestudy.Repositories.UserRepository;
import com.rohlik.rohlikcasestudy.Services.UserService;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@AllArgsConstructor
@RequestMapping("/")
public class AdministrationController {

    UserService userService;
    UserRepository userRepository;

    @GetMapping()
    public String listUsers(Model model){

        model.addAttribute("users", userRepository.findAll());

        return "UserOverview";
    }

    @GetMapping("/{id}/status")
    public String changeStatus(@PathVariable(name = "id") Long id){

        userService.changeStatus(id);

        return "redirect:/";
    }

    @PostMapping("/search")
    public String searchUsers(String searchInput, Model model){

        List<User> users = userService.searchUsers(searchInput);

        model.addAttribute("users", users);

        return "UserOverview";
    }
}
