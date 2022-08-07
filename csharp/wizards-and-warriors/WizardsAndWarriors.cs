using System;

abstract class Character
{
    public string characterType;
    public bool vulnerable = false;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
        // throw new NotImplementedException("Please implement the Character() constructor");
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {

        return this.vulnerable;
    }

    public override string ToString()
    {
        return "Character is a " + characterType;
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }



    public override int DamagePoints(Character target)
    {
        if(target.vulnerable == true){
            return 10;
        } else {
            return 6;
        }    }
}

class Wizard : Character
{
    public bool spellPrepared = false;
    public Wizard() : base("Wizard")
    {
        this.vulnerable = true;
    }


    public override int DamagePoints(Character target)
    {
        if(spellPrepared == true){
            return 12;
        } else {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        this.spellPrepared = true;
        this.vulnerable = false;
    }
}
