namespace Lab4
{
    public static class BinarySearch
    {
        public static int FindElement(double[] buf, double To_Find)
        {
            if (buf.Length == 0)    //1
                return -2; //end

            var sorted = buf.ToList();      //2
            sorted.Sort();                  //2
            var v = sorted.ToArray();       //2
            int lo = 0;                     //2
            int hi = v.Length - 1;          //2
            int mid;                        //2

            while (hi - lo > 1)             //3
            {
                mid = (hi + lo) / 2;        //4
                if (v[mid] < To_Find)       //5
                    lo = mid + 1;           //6
                else hi = mid;              //7
            }                               //8
            if (v[lo] == To_Find)           //9
                return lo;                  //end
            else if (v[hi] == To_Find)      //10
                return hi;                  //end
            else                            //11
                return -1;                  //end
        }
    }
}
