namespace leetcode
{
    public class RobotReturnToOrigin
    {
        public static bool JudgeCircle(string moves) {
            
            if(moves.Length < 2) return false;
        
            var ud = 0;
            var lr = 0;
            
            
            for(int i = 0; i < moves.Length; i++){
                if(moves[i] == 'U'){
                    ud++;
                } else if(moves[i] == 'D'){
                    ud--;
                } else if(moves[i] == 'R'){
                    lr++;
                } else {
                    lr--;
                }
            }
            
            return ud == 0 && lr == 0;
        }
    }
}