namespace c_
{
    public class HouseRobber
    {
        public int Rob(int[] arr)
        {
            int back1 = 0;
            int back2 = 0;
            int currentVal = 0;
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] + back2 > back1)
                {
                    currentVal = arr[i] + back2;
                }

                back2 = back1;
                back1 = currentVal;
            }

            return back1;

        }
    }
}