namespace StudentClassLibrary
{
    /// <summary>
    /// Student class indeholder data om de studerende
    /// navn mv.
    /// </summary>
    public class Student
    {
        public string MyName { get; set; }


        /// <summary>
        /// Denne metode returnere navnet på den studerende
        /// </summary>
        /// <returns> "Mit navn: " mynavn </returns>
        public string MyNameText()
        {
            return "Mit navn: " + MyName;
        }

        public string MYNEWNameText()
        {
            return "Noegt nyt tejkst";
        }


    }
}