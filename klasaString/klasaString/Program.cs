using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            s1 = "Hrvatska ima more";
            s2 = "Italija je prvak svijeta";
            s3 = s1[:8] + s2[6:];
            print("s3 =", s3);
        }
        tekst = input("Unesite niz znakova: ");
        tekst = tekst.replace(" ", "_");
        print("Rezultat:", tekst);
        tekst = input("Unesite niz znakova: ");
        sVelika = tekst.upper();
        sMala = tekst.lower();
        sPrvaTri = tekst[:3];
        sZadnjihPet = tekst[-5:];
        s8_11 = tekst[7:11];
            print("sVelika:", sVelika);
        print("sMala:", sMala);
        print("sPrvaTri:", sPrvaTri);
        print("sZadnjihPet:", sZadnjihPet);
        print("s8_11:", s8_11);


    }

    recenica = input("Unesite rečenicu: ");
rijeci = recenica.split();
if len(rijeci) > 0:
    print("Prva riječ:", rijeci[0]);
    print("Zadnja riječ:", rijeci[-1]) else:
    print("Niste unijeli rečenicu.");
    unos = input("Unesite cijeli i decimalni broj odvojene razmakom: ");
x, y = map(float, unos.split());
    print("Dvostruka vrijednost cijelog broja:", x* 2);
    print("Dvostruka vrijednost decimalnog broja:", y* 2);


}
