namespace RetezUtil
{
    static public class Retezec
    {
        /// <summary>
        /// Smaže všechny číslice ze stringu.
        /// </summary>
        /// <param name="x">Řetězec pro vymazání.</param>
        /// <returns>String</returns>
        static public string Smaz(string x)
        {
            string y = "0123456789";
            foreach(char i in y)
                x = x.Replace(i.ToString(), "");
            return x;
        }

        /// <summary>
        /// Zobrazí výpis
        /// </summary>
        /// <returns>String</returns>

        static public string Zobraz()
        {
            return "Výpisss";
        }
    }
}