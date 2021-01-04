# NET_Project

This project was made following the next rules 

## General 

The idea is to build a basic app to buy parking and to check the parkings

The accounts we create will have a phone number associate with a balance, this balance will be discounted when that number is doing a purchase 

Every purchase will have all the information: Account associate , the start and finish time of the parking, the day and the license plate associated to. The default value of day is the current day. 

For checking the parkings, we will need the licence plate, day and time to check. 

User could change amount per minute, default value is 3. 

## Rules 

Phones numbers will be 098 898 989 or 98 987 879 , the user could fill the information will spaces or not, we validate the data when we create the Account associate to that number 

The text where a person buy a parking should have the format "SBN 1345 150 10:00" , the space in the license plate could not be there, the ammount of minutes ask for the parking will be multiple of 30, and the start time could be or not (if the text does not have the init hour, the system will be provide with the current time)

The info to check the parking has two parts, the licence plate and the follow message : "12/10 12:00" . All the infor has to be there to ckeck if the license plata has a parking at that time in the day we are asking for. 

If we ask to buy parking , has to bee from 10 to 18, with the format 24 hs. If the user trys to buy 30 minutes of parking from 17:40 , will only get 20 minutes and the amount discount to the account will be 20 and not 30.
