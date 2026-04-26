using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_Classes_Objects
{
    class Angle
    {
        int gradus, minute, second;
        public bool isCorrect = true;
        

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    gradus = value % 360;
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else 
                {
                    Gradus += value / 60;
                    minute = value % 60;
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    Minute += value / 60;
                    second = value % 60;
                }
            }
        }

        public Angle(int gradus, int minute, int second)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Second = second;
        }
        public double toRadian()
        { 
            return(double) (gradus + minute / 60.0 + second / 3600.0) * Math.PI / 180.0; 
        }
    }
}
