public class Solution {
    public int MaxArea(int[] height) {

        int area =0;
        for(int i=0; i<height.Length-1;i++)
        {
            if(height[i]*height.Length-1<area) continue;
            for(int j=i+1;j<height.Length;j++)
            {
                int smallest = height[i]<height[j] ? height[i]:height[j];
                int distance =j-i;
                int currentArea=smallest*distance;

                if(currentArea>area)
                {
                    area=currentArea;
                }
            }
        }
        return area;
        
    }

}