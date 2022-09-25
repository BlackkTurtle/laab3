using System;
using System.Runtime.ConstrainedExecution;

class GFG
{
    class Rectangle
    {
        public string id;
        public int width;
        public int height;
        public int x1;
        public int y1;
    }
    class Point
    {
        public int x, y;
    }
    static Rectangle RectangleCreate(string[] array1)
    {
        Rectangle rectanglecreate = new Rectangle();
        rectanglecreate.id = array1[0];
        rectanglecreate.width = Convert.ToInt32(array1[1]);
        rectanglecreate.height = Convert.ToInt32(array1[2]);
        rectanglecreate.x1 = Convert.ToInt32(array1[3]);
        rectanglecreate.y1 = Convert.ToInt32(array1[4]);
        return (rectanglecreate);
    }
    static bool IntersectionCheck(int width1,int height1,int x1,int y1,int width2,int height2,int x2,int y2)
    {
        Point l1=new Point();Point l2=new Point();Point r1=new Point();Point r2=new Point();
        l1.x = x1;l1.y= y1;
        l2.x=x1+width1;l2.y = y1+height1;
        r1.x = x2;r1.y=y2;
        r2.x=x2+width2;r2.y=y2+height2;
        if (l1.x == r1.x || l1.y == r1.y || r2.x == l2.x || l2.y == r2.y)
        {
            return(true);
        }
        if (l1.x > r2.x || l2.x > r1.x)
        {
            return(true);
        }
        if (r1.y > l2.y || r2.y > l1.y)
        {
            return(true);
        }
        return(false);
    }
    public static void Main()
    {
        Console.WriteLine("Numbers: ");
        string narray = Console.ReadLine();
        string[] narray1 = narray.Split(' ');
        Rectangle[] rectangles = new Rectangle[Convert.ToInt32(narray1[0])];
        for (int i = 0; i < rectangles.Length; i++)
        {
            string strarray = Console.ReadLine();
            string[] array1 = strarray.Split(' ');
            rectangles[i] = RectangleCreate(array1);
        }
        for (int i = 0; i < Convert.ToInt32(narray1[1]); i++)
        {
            string strarray = Console.ReadLine();
            string[] array1 = strarray.Split(' ');
            string[] array2 = new string[rectangles.Length];
            for (int j = 0; j < rectangles.Length; j++)
            {
                array2[j] = rectangles[j].id;
            }
            int index1=Array.IndexOf(array2,array1[0]);
            int index2=Array.IndexOf(array2,array1[1]);
            Console.WriteLine(IntersectionCheck(rectangles[index1].width, rectangles[index1].height, rectangles[index1].x1, rectangles[index1].y1, rectangles[index2].width, rectangles[index2].height, rectangles[index2].x1, rectangles[index2].y1));
        }
    }
}
