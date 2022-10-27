// Mark A Ramirez 
// 1027/2022
// Resturant Picker
// when you start just put the class and then it will guide you thru to do the rest
// peer reviwed by: Chris Martinez, I tested the url for restaurant picker, and I was able to randomly genereate from list available. 


using Microsoft.AspNetCore.Mvc;

namespace RamirezM_Resturant_Picker_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ResturantPickerController : ControllerBase
{
    public string ResturantPicker(){
    return $"choose -resturant- -fast food- -date night- -random- ";
    }

    [HttpGet]
    [Route("{userinput}")]
public string megaMart(string userinput){
    switch(userinput)
{
case "resturant":
Random rndNum = new Random();
int Rnum = rndNum.Next(0, 9);


string[] Res = { "Market Tavern", "Dave Wongs", "Mezzo", "WaterLoo", "Lumberjacks Restaurant", "Omelet House", "Moo Moo's Burger Barn", "Tommy's Cafe", "Mi Ranchito", "Romano's Macaroni Grill" };

return (Res[Rnum]);


case "fast food":
Random RndNum = new Random();
int RNum = RndNum.Next(0, 9);


string[] FF = {"Raising Cane's Chicken Fingers","Chick-fil-A","Sonic Drive-in","Super Burger Drive in","In-N-Out Burger","Popeyes","Angry Chickz","taco bell","Indian Delicacies","Jack in The box"};

return (FF[RNum]);


case "date night":
Random rNdNum = new Random();
int RnUm = rNdNum.Next(0, 9);


string[] DN = {"Prime Table","The Black Rabbit","Market Tavern","The Kitchen At StoneBrier","Midgleys Public House","EL Rancho Inn-Streak & Lobster House","Ave On The Mile","Cast Iorn Trading","WildFire Public House","The BoatHouse At River Isalnds"};

return (DN[RnUm]);


case "random":
Random rnDNum = new Random();
int RnuM = rnDNum.Next(0, 29);


string[] Ran = {"Market Tavern","Dave Wongs","Mezzo","WaterLoo","Lumberjacks Restaurant","Omelet House","Moo Moo's Burger Barn","Tommy's Cafe","Mi Ranchito","Romano's Macaroni Grill","Raising Cane's Chicken Fingers","Chick-fil-A","Sonic Drive-in","Super Burger Drive in","In-N-Out Burger","Popeyes","Angry Chickz","taco bell","Indian Delicacies","Jack in The box","Prime Table","The Black Rabbit","Market Tavern","The Kitchen At StoneBrier","Midgleys Public House","EL Rancho Inn-Streak & Lobster House","Ave On The Mile","Cast Iorn Trading","WildFire Public House","The BoatHouse At River Isalnds"};

return (Ran[RnuM]);

default:
return $"nope spell it how i put it not like this {userinput}";

}
}

}
