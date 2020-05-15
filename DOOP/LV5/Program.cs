using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        { //5. zadatak
           
            GroupNote groupNote1 = new GroupNote("Grupna poruka 1",new BlueTheme());
            groupNote1.AddName("Mario");
            groupNote1.AddName("Ante");
            groupNote1.AddName("Petar");
            groupNote1.Show();
            GroupNote groupNote2 = new GroupNote("Grupna poruka 2", new LightTheme());
            groupNote2.AddName("Martin");
            groupNote2.AddName("Marijan");
            groupNote2.Show();
        }
    }
}
