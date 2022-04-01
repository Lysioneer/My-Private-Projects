# character_name = "Marcus"
# character_age = "35"

# puts ("There once was a man named " + character_name)
# puts ("he was " + character_age + " years old")

# character_name = "Thomas"

# puts ("He really liked the name " + character_name)
# puts ("but didn't like being " + character_age)

# name = "Mike"
# occupation = "programmer"
# age = 54
# gpa = 2.5654824
# ismale = true
# istall = false
# flaws = nil

# puts "Hello\n \"there\""

# puts name.upcase()
# puts name.downcase()

# phrase = "          Hello"

# puts phrase.strip()
# puts phrase.include? "ello"
# puts name[0]
# puts name[0, 3]
# puts name.index("k")

# puts age + gpa

# puts 2**3
# puts 10 % 3
# num = -20.546
# puts ("My fav number is " + num.to_s)
# puts num.abs()
# puts num.round()
# puts Math.sqrt(16)

# puts "Enter your name: "
# name = gets.chomp()
# puts ("Hello " + name + " you are cool")

# puts "Enter first number: "
# num1 = gets.chomp()
# puts "Enter another number: "
# num2 = gets.chomp()

# puts num1.to_i + num2.to_i

# friends = Array["Hanz", "Michael", "Kevin", "Karen"]
# print friends
# puts
# puts friends[1]
# puts friends[-1]
# puts friends[0, 2]

# friends [1] = "Dwight"
# print friends

# another_friends = Array.new

# puts another_friends[0]
# another_friends[0] = "Hallo"
# print another_friends

# puts friends.length()
# puts friends.sort()

# HASH maps!!!

# states = {
#     :Pennsylvania => "PA",
#     "New York" => "NY",
#     "California" => "CA"
# }

# puts states
# puts states["California"]
# puts states[:Pennsylvania]

# METHODS

# def sayhi(name = "no name", age = -1)

#     puts ("Hello " + name + " you are " + age.to_s)

# end

# sayhi("Hanz", 21)

# RETURN STATEMENT

# def cube(num1)

#     return num1 * num1 * num1, 70
# end

# puts cube(3)[1]
# print cube(2)

# IF STATEMENETS

# ismale = false
# istall = false

# if ismale && istall
#     puts "You are male and tall"
# elsif ismale && !istall
#     puts "You are male and short"
# elsif !ismale && istall
#     puts "You are not a male but you are tall"
# else
#     puts "You are not male and you are not tall"
# end

# SWITCH/CASE STATEMENT

# def get_day_name(day)
#     day_name = ""

#     case day
#     when "mon"
#         day_name = "Monday"
#     when "tue"
#         day_name = "Tuesday"
#     when "wed"
#         day_name = "Wednesday"
#     when "thu"
#         day_name = "Thursday"
#     when "fri"
#         day_name = "Friday"
#     when "sat"
#         day_name = "Saturday"
#     when "sun"
#         day_name = "Sunday"
#     else
#         day_name = "Invalid Input"
#     end

#     return day_name
# end

# puts get_day_name("fri")

# WHILE LOOP

# index = 1

# while index <= 5
#     puts index
#     index += 1
# end

# FOR LOOP

# friends = ["Hanz", "Lucias", "Antonin", "Rosta Lopata"]

# for frined in friends
#     puts frined
# end

# friends.each do |friend|
#     puts friend
# end

# for index in 0..5
#     puts index
# end

# 6.times do |index|
#     puts index
# end

# EXPONENTIAL METHOD

def pow(base_num, pow_num)
    result = 1

    pow_num.times do |index|
        result = result * base_num
    end

    return result
end

puts pow(2, 8)