using System.Collections.Generic;
namespace Area_Calc_Gabriel
{
    public static class AreaCalculator
    {
        public static double  getSquareArea(int side)
        {
            return side * side;
        }
        public static double getSquareArea(string side)
        {
            try
            {
                Dictionary<string, int> D = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                D.Add("one", 1);
                D.Add("two", 2);
                D.Add("three", 3);
                D.Add("four", 4);
                D.Add("five", 5);
                D.Add("six", 6);
                D.Add("seven", 7);
                D.Add("eight", 8);
                D.Add("nine", 9);
                D.Add("ten", 10);
                return D[side] * D[side];
            }
            catch (Exception)
            {

                throw;
            }        
        }
        public static double getRectangleArea(int width, int height)
        {           
            return width * height;
        }
        public static double getTriangleArea(int Base, int height)
        {
            Double area = Base * height*1 / 2;
            Double roundedArea = Math.Round((double)area, 2);
            return roundedArea;
        }
        public static double getParallelogramArea(int height, int Base)
        {      
             return height* Base;
        }
        public static double getCircleRadius(int diameter)
        {
            Double area = diameter / 2;
            Double roundedArea = Math.Round((double)area, 2);
            return roundedArea;         
        }
        public static double getCircleDiameter(int radius)
        {               
            return radius * 2;
        }
    }
}
