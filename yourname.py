# this is imports used to bring in libarise into the project 
import os 
import random 

# this is a string which will ask the user for input then will store that input as the Forename 
Forneame = input("Please enter your frist name >: ")

# same for how this line works
Surname = input("PLease enter your last name >: ")

# this string is used to hold both the Forname and the surname and one varible 
Fullname = Forneame + " " + Surname

# simple code to say welcome then it adds the name you had input 
print("Welcome " + Fullname)

# this will be a number but will act like a string until we convert it i will point out where we did that
age = input("How old are you " + Forneame)

# you will need to use int before the varible in order to convert it 
if int(age) >= 25:

  print("you are 25 or over")

# instead of using else after if we use elif 
elif int(age) <= 24:

  print("you are 24 or under")



print("end of program")