using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class BasicSkill
    {
        //public struct Skill
        //{
        //    public int id;
        //    public char c;
        //    public string comment;
        //}

        public static int Id(char c)
        {
            switch (c)
            {
                case 'S': return 0;
                case 'R': return 1;
                case 'A': return 2;
                case 'B': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                default: return -1;
            }
        }
        
        public static char Character(int id)
        {
            switch (id)
            {
                case 0: return 'S';
                case 1: return 'R';
                case 2: return 'A';
                case 3: return 'B';
                case 4: return 'D';
                case 5: return 'E';
                case 6: return 'F';
                default: return '_'; // TODO:
            }
        }

        public static string Comment(int id)
        {
            switch (id)
            {
                case 0: return "Serve";
                case 1: return "Reception";
                case 2: return "Attack";
                case 3: return "Block";
                case 4: return "Dig Defence";
                case 5: return "sEt";
                case 6: return "Free ball";
                default: return "";
            }
        }

        public static char[] Characters()
        {
            return new char[] { 'S', 'R', 'A', 'B', 'D', 'E', 'F' };
        }
    }
}
