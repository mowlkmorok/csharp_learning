using System;



namespace Cron_Watch
{
    class Program
    {
        static void Main(string[] args)
        {

            EntryMenuOpt();


        }
        //-----Menu Options Function
        static void EntryMenuOpt()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("1 - Cronometer");
            Console.WriteLine("2 - Exit\n\nSet Options: ");
            

            string opt1 = Console.ReadLine()!; 

            switch (opt1)
            {   
                case "1":
                    SetCronOpt();
                    break;

                case "2":
                    System.Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Something is wrong [!]");

                    Thread.Sleep(2000);
                    EntryMenuOpt();
                    break;
            }



        }

        //-----End Menu Function




        
        //-----Menu Options Function
        static void SetCronOpt()
        {
            TimerWatch _THE_TIME = new TimerWatch();

            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("Command Syntax:");
            Console.WriteLine("10s( 10 second ) or 10m( 10 Minutes )");
            Console.WriteLine("Exemple:");
            Console.WriteLine("10s (10 Seconds)\n Or\n10m (10 Minutes)");
            Console.WriteLine("*********************************************");

            Console.WriteLine("Type time: ");

            
            string timer_Cronometre = Console.ReadLine()!;          

        
            _THE_TIME.Second = timer_Cronometre;
            _THE_TIME.Minutes = timer_Cronometre;

            _THE_TIME.ContTime();



        }

        //-----End Menu Function
    }





    struct TimerWatch
    {

        public string Second;
        public string Minutes;
        


        public void ContTime()
        {

            string timerType;
            timerType = Second;
            timerType = Minutes;

            

            //----GET SECONDS NUMBER=
            string number_sec = this.Second.Substring(0, this.Second.Length-1);

            //----GET MINUTES NUMBER=
            string number_min = this.Minutes.Substring(0, this.Minutes.Length-1);


            //----GET TIME TYPE
            string timer_type = timerType.Substring(timerType.Length-1, 1);

            //TIMES
            int Time_sec;
            int Time_min;


            //----TO TRY CONVERT TO INT
            try
            {
                Time_sec = int.Parse(number_sec);
                Time_min = int.Parse(number_min);
            }
            catch (System.Exception)
            {
                Console.WriteLine("---------");
                Console.WriteLine("Error [!]");
                throw;
            }

                Console.WriteLine("-----------------------");
                Console.WriteLine($"Second type: {Time_sec}");
                Console.WriteLine($"Minutes type: {Time_min}");


                //--TIME TYPE Treatments of string
                timer_type.ToLower();

                switch (timer_type)
                {
                    case "s":
                        Second_Counter(Time_sec);
                        break;

                    case "m":
                        Minute_Conuter(Time_min);
                        break;
                    default:
                        Console.WriteLine("Syntax error [!]");
                        Console.WriteLine("*********************************************");
                        break;
                }



                if(timer_type == "s")
                    Second_Counter(Time_sec);
                

        }

        private static void Second_Counter(int sec)
        {
            int count_sec = sec;

            while (count_sec >= 0)
            {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Time: {count_sec}sec");

                Thread.Sleep(1000);


                count_sec -= 1;
            } 

            System.Environment.Exit(0);
        }


        private static void Minute_Conuter(int min)
        {   
            int time1 = min * 60;
            int minutes = time1 / 60;


            
            int minute_seconds = 60;

            while (minutes > 0)
            {
            
                Console.Clear();
                Console.WriteLine("-----------------------");

                Console.WriteLine($"Time: {minutes}Min :{minute_seconds}sec");


                if(minute_seconds == 0)
                {
                    minute_seconds = 60;
                    minutes -= 1;
                }


                Thread.Sleep(1000);
                minute_seconds -= 1;
                
            }

            System.Environment.Exit(0);

        }        


    }

}