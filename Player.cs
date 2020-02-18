namespace LemonadeStand_3DayStarter
{
    public class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        

        // constructor (SPAWNER)
        public Player()
        {
            name = "Name";
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }
        public void MakePitcher()
        {
            

        }
       
        public void SubtractLemonsFromInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i--)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
        }

        public void SubtractSugarCubesFromInventory(int numberOfSugarCubes)
        {
            for (int i = 0; i < numberOfSugarCubes; i--)
            {
                SugarCube sugarCube = new SugarCube();
               inventory.sugarCubes.Add(sugarCube);
            }
        }

        public void SubtractIceCubesFromInventory(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i--)
            {
                IceCube iceCube = new IceCube();
               inventory.iceCubes.Add(iceCube);
            }
        }

        public void SubtractCupsFromInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i--)
            {
                Cup cup = new Cup();
               inventory.cups.Add(cup);
            }


        }




    }  
}
