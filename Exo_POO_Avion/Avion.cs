using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_POO_Avion
{
    class Avion
    {
        string Marque;
        string Modele;
        int Vitesse_Max;
        int Vitesse_Cours;
        int Altitude_Cours;
        int Altitude_Max;

        public void Init_Avion()
        {
        }

        public void Etat_Avion(string Mq,int Vmax,int Amax)
        {
            
        }

        public void decoller()
        {
            for (int i = Vitesse_Cours; i < Vitesse_Max; i++)
            {
                i = i + 10;

                
            }

            if (Vitesse_Cours >= 300)
            {
                for (int i = 0; i < Altitude_Max; i++)
                {
                    Altitude_Cours = Altitude_Cours + 200;
                }
            }


        }
    }
}
