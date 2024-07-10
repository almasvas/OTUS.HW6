namespace OTUS.HW6
{
    public class SpaceCounter
    {
        public static int CountSpaces(string content)
        {
            return content.Count(c => c == ' ');
        }
    }
}
