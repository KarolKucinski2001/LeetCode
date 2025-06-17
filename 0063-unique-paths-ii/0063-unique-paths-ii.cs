public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {

        int nr = obstacleGrid.Length;
        int nc = obstacleGrid[0].Length;
        var newGrid =  new int[nr,nc];

        if(obstacleGrid[0][0]==1)
        {
            return 0;
        }

        newGrid[0,0]=1;

        for(int i=1;i<nr;i++)
        {
            newGrid[i,0]=(obstacleGrid[i][0] == 0 && newGrid[i-1,0] == 1) ? 1: 0;
        }

        for(int j=1; j<nc;j++)
        {
            newGrid[0,j] = (obstacleGrid[0][j] == 0 && newGrid[0,j-1] == 1) ? 1 : 0;

        }

        for(int i=1;i<nr;i++)
        {
            for(int j=1;j<nc;j++)
            {
                if(obstacleGrid[i][j]==0)
                {
                newGrid[i,j]=newGrid[i-1,j] + newGrid[i,j-1];
                }
                
            }
        }
        return newGrid[nr-1,nc-1];


        
    }
}