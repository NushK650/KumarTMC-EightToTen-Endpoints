Name: Tanush Kumar
Date: 1/9/25
Project Name: EightToTen

Description:  Design an API based on mini challenges from the Combine:
Also, each one must have their own service file, inside a Service folder
Data Validation is required.

Endpoints:

1. Magic 8 Ball: create a endpoint generates 8 unique responses. One controller


2. Guess It: create 3 endpoints (one controller) that takes an input, then outputs if the number is higher or lower than the number guessed.
Easy Mode 1-10
Medium Mode 1-50
Hard Mode 1-100

3. Restaurant Picker: create 1 endpoint that takes an input and generates a Randomly Generated Restaurant based on the category chosen. 10 Restaurants per category.


Peer review: Thao Vang
"
Magig8Ball - everything looks good
GuessIt - they want us to have 3 routes so you dont need to validate easy medium or hard just the number. for validation of number use a string then tryparse and tell user if they wrote a number or not. also for validation you should indicate the values of the game mode
RestaurantPicker - No indicator of what categories I can choose from. suggetst something in the controller variables to indicate or have the validation indicate options available. for the casual dining I think one of the option (sunshine cafe) has extra characters in it be accident. otherwise it works great
"