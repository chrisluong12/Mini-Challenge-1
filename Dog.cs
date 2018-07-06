using System;
namespace URLEncoder
{
    public class Dog
    {
        public string name = "";
        public string owner = "";
        public int age;
        Gender sex;

        enum Gender{
            Male,
            Female
        }

        Dog(string name, string owner, int age, Gender sex)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.sex = sex;
        }

        public int bark (int count)
        {
            int i = 0;

            for (i = 0; i < count; i++)
            {
                Console.WriteLine("Woof!");
            }

            return 0;
        }

        public string getTag()
        {
            string lost_call = "";

            if (this.sex == Gender.Male)
            {

                if(this.age == 1)
                {
                    lost_call = "If lost, call " + this.owner + ". His name is " + this.name + " and he is " + this.age + " year old.";
                }
                else{
                    lost_call = "If lost, call " + this.owner + ". His name is " + this.name + " and he is " + this.age + " years old.";
                }
            }

            if (this.sex == Gender.Female)
            {
                if (this.age == 1)
                {
                    lost_call = "If lost, call " + this.owner + ". Her name is " + this.name + " and she is " + this.age + " year old.";
                }
                else
                {
                    lost_call = "If lost, call " + this.owner + ". Her name is " + this.name + " and she is " + this.age + " years old.";
                }
            }

            return lost_call;
        }

        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.


        }

    }
}
