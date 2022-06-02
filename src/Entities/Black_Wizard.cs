namespace src.Entities
{
    public class Black_Wizard : Hero
    {
      public Black_Wizard(string Name , int Level , string Herotype)
      {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;

      }  
        public override string Attack(){
          return this.Name + " Atacou com sua magia negra";
       }
    }
}