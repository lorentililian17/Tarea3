using static System.Console;

namespace Using
{
    class Program
    {
        public static void Main()
        {
            int CAN, C100, C50, C20, C10, C5;
            CAN = C100 = C50 = C20 = C10 = C5 = 0;
            string linea;

            decimal cantidad_moneda;
            decimal TIPO_CAMBIO = 7.65m;

            Console.Write("Ingrese Una Cantidad En Dolares:");
            linea = Console.ReadLine();
            CAN = Convert.ToInt32(linea);

            cantidad_moneda = Convert.ToDecimal(linea);

            cantidad_moneda = (cantidad_moneda * TIPO_CAMBIO);

            Console.WriteLine($"Convirtiendo A Quetzales {cantidad_moneda}");

            CAN = Convert.ToInt32(Math.Truncate(cantidad_moneda));

            cantidad_moneda = (cantidad_moneda - CAN) * 100;
            Console.WriteLine($"Monedas = {cantidad_moneda}");

            if ((CAN >= 100))
            {
                C100 = (CAN / 100);
                CAN = CAN - (C100 * 100);
            }

            if ((CAN >= 50))
            {
                C50 = (CAN / 50);
                CAN = CAN - (C50 * 50);
            }

            if ((CAN >= 20))
            {
                C20 = (CAN / 20);
                CAN = CAN - (C20 * 20);
            }

            if ((CAN >= 10))
            {
                C10 = (CAN / 10);
                CAN = CAN - (C10 * 10);
            }

            if (CAN >= 5)
            {
                C5 = (CAN / 5);
                CAN = CAN - (C5 * 5);
            }

            Console.WriteLine($"--- Estos Son Tus Billetes ---");
            Console.WriteLine($"Billetes De 100: {C100}");
            Console.WriteLine($"Billetes De 50: {C50}");
            Console.WriteLine($"Billetes De 20: {C20}");
            Console.WriteLine($"Billetes De 10: {C10}");
            Console.WriteLine($"Billetes De 5: {C5}");
            Console.WriteLine($"Billetes De 1: {CAN}");

        }
    }
}
