using System;
namespace CodingChallenges.Problems
{
    public class MilitaryTimeConversion
    {
        //Convert 12-Hour format to 24 Hour format
        private string time;
        public MilitaryTimeConversion(string time)
        {
            this.time = time;
        }

        public void Convert()
        {
            string[] arr = time.Split(":");
            string amPm = arr[2].Substring(2, 2);
            arr[2] = arr[2].Substring(0, 2);
            if (amPm.Equals("PM") && !arr[0].Equals("12"))
                arr[0] = (Int32.Parse(arr[0]) + 12).ToString();
            else if(amPm.Equals("AM") && arr[0].Equals("12"))
                arr[0] = "00";
            
            string militaryTime = string.Join(':', arr);
            Console.WriteLine(militaryTime);
        }
    }
}
