namespace RetezUtil
{
    static public class Retezec
    {
        /// <summary>
        /// Smaže všechny číslice ze stringu.
        /// </summary>
        /// <param name="x">Řetězec pro vymazání.</param>
        /// <returns></returns>
        static public string Smaz(string x)
        {
            string y = "0123456789";
            foreach(char i in y)
                x.Replace(i, 'X');
            return x;
        }
    }
}