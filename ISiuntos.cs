using System.Collections.Generic;

namespace MiniParduotuve2
{
    interface ISiuntos
    {
        double SKaina { get; set; }
        double MKaina { get; set; }
        double LKaina { get; set; }

        List<Preke> Krepselis { get; set; }

    }

    class SiuntosPaštas : ISiuntos
    {
        public double SKaina { get; set; }
        public double MKaina { get; set; }
        public double LKaina { get; set; }
        public List<Preke> Krepselis { get; set; }


        public SiuntosPaštas(List<Preke> krepselis, out char siuntosDydis, out double siuntimoKaina, out double suma)
        {

            double sKaina = 2.29;
            double mKaina = 3.29;
            double lKaina = 4.49;
            double siuntimoKaina1 = 0;
            siuntosDydis = ' ';
            int sKiekis = 0;
            int mKiekis = 0;

            Krepselis = krepselis;
            double prekiuKaina = 0;
            foreach (var item in krepselis)
            {
                prekiuKaina += item.Kaina;
                if (siuntosDydis == 'L')
                {
                    break;
                }
                else
                {
                    if (item.Dydis == 'L')
                    {
                        siuntosDydis = 'L';
                    }
                    else if (item.Dydis == 'M')
                    {
                        siuntosDydis = 'M';
                        mKiekis++;
                        
                    }
                    else if (item.Dydis == 'S')
                    {
                        siuntosDydis = 'S';
                        sKiekis++;
                        
                    }

                }
            }
            if (siuntosDydis != 'L')
            {
                if (mKiekis > 3)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 9)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 3)
                {
                    siuntosDydis = 'M';
                }
            }
            if (siuntosDydis == 'L')
            {
                siuntimoKaina1 = lKaina;
            }
            else if (siuntosDydis == 'M')
            {
                siuntimoKaina1 = mKaina;

            }
            else if (siuntosDydis == 'S')
            {
                siuntimoKaina1 = sKaina;
            }
            siuntimoKaina = siuntimoKaina1;
            suma = siuntimoKaina1 + prekiuKaina;
        }
    }
    class Kurjeriu : ISiuntos
    {
        public double SKaina { get; set; }
        public double MKaina { get; set; }
        public double LKaina { get; set; }
        public List<Preke> Krepselis { get; set; }


        public Kurjeriu(List<Preke> krepselis, out char siuntosDydis, out double siuntimoKaina, out double suma)
        {

            double sKaina = 4.29;
            double mKaina = 5.99;
            double lKaina = 7.49;
            double siuntimoKaina1 = 0;
            siuntosDydis = ' ';
            int sKiekis = 0;
            int mKiekis = 0;

            Krepselis = krepselis;
            double prekiuKaina = 0;
            foreach (var item in krepselis)
            {
                prekiuKaina += item.Kaina;
                if (siuntosDydis == 'L')
                {
                    break;
                }
                else
                {
                    if (item.Dydis == 'L')
                    {
                        siuntosDydis = 'L';
                    }
                    else if (item.Dydis == 'M')
                    {
                        siuntosDydis = 'M';
                        mKiekis++;
                        
                    }
                    else if (item.Dydis == 'S')
                    {
                        siuntosDydis = 'S';
                        sKiekis++;
                        
                    }

                }
            }
            if (siuntosDydis != 'L')
            {
                if (mKiekis > 3)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 9)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 3)
                {
                    siuntosDydis = 'M';
                }
            }
            if (siuntosDydis == 'L')
            {
                siuntimoKaina1 = lKaina;
            }
            else if (siuntosDydis == 'M')
            {
                siuntimoKaina1 = mKaina;

            }
            else if (siuntosDydis == 'S')
            {
                siuntimoKaina1 = sKaina;
            }
            siuntimoKaina = siuntimoKaina1;
            suma = siuntimoKaina1 + prekiuKaina;
        }
    }
    class Pastomatu : ISiuntos
    {
        public double SKaina { get; set; }
        public double MKaina { get; set; }
        public double LKaina { get; set; }
        public List<Preke> Krepselis { get; set; }


        public Pastomatu(List<Preke> krepselis, out char siuntosDydis, out double siuntimoKaina, out double suma)
        {

            double sKaina = 1.29;
            double mKaina = 2.29;
            double lKaina = 3.49;
            double siuntimoKaina1 = 0;
            siuntosDydis = ' ';
            int sKiekis = 0;
            int mKiekis = 0;

            Krepselis = krepselis;
            double prekiuKaina = 0;
            foreach (var item in krepselis)
            {
                prekiuKaina += item.Kaina;
                if (siuntosDydis == 'L')
                {
                    break;
                }
                else
                {
                    if (item.Dydis == 'L')
                    {
                        siuntosDydis = 'L';
                    }
                    else if (item.Dydis == 'M')
                    {
                        siuntosDydis = 'M';
                        mKiekis++;
                        
                    }
                    else if (item.Dydis == 'S')
                    {
                        siuntosDydis = 'S';
                        sKiekis++;
                        
                    }

                }
            }
            if (siuntosDydis != 'L')
            {
                if (mKiekis > 3)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 9)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 3)
                {
                    siuntosDydis = 'M';
                }
            }
            if (siuntosDydis == 'L')
            {
                siuntimoKaina1 = lKaina;
            }
            else if (siuntosDydis == 'M')
            {
                siuntimoKaina1 = mKaina;

            }
            else if (siuntosDydis == 'S')
            {
                siuntimoKaina1 = sKaina;
            }
            siuntimoKaina = siuntimoKaina1;
            suma = siuntimoKaina1 + prekiuKaina;
        }
    }
    class Tarptautines : ISiuntos
    {
        public double SKaina { get; set; }
        public double MKaina { get; set; }
        public double LKaina { get; set; }
        public List<Preke> Krepselis { get; set; }


        public Tarptautines(List<Preke> krepselis, out char siuntosDydis, out double siuntimoKaina, out double suma)
        {

            double sKaina = 12.29;
            double mKaina = 15.29;
            double lKaina = 20.49;
            double siuntimoKaina1 = 0;
            siuntosDydis = ' ';
            int sKiekis = 0;
            int mKiekis = 0;

            Krepselis = krepselis;
            double prekiuKaina = 0;
            foreach (var item in krepselis)
            {
                prekiuKaina += item.Kaina;
                if (siuntosDydis == 'L')
                {
                    break;
                }
                else
                {
                    if (item.Dydis == 'L')
                    {
                        siuntosDydis = 'L';
                    }
                    else if (item.Dydis == 'M')
                    {
                        siuntosDydis = 'M';
                        mKiekis++;
                        
                    }
                    else if (item.Dydis == 'S')
                    {
                        siuntosDydis = 'S';
                        sKiekis++;
                        
                    }

                }
            }
            if (siuntosDydis != 'L')
            {
                if (mKiekis > 3)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 9)
                {
                    siuntosDydis = 'L';
                }
                else if (sKiekis > 3)
                {
                    siuntosDydis = 'M';
                }
            }
            if (siuntosDydis == 'L')
            {
                siuntimoKaina1 = lKaina;
            }
            else if (siuntosDydis == 'M')
            {
                siuntimoKaina1 = mKaina;

            }
            else if (siuntosDydis == 'S')
            {
                siuntimoKaina1 = sKaina;
            }
            siuntimoKaina = siuntimoKaina1;
            suma = siuntimoKaina1 + prekiuKaina;
        }
    }
}


        
        
    

