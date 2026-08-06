public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        (int pos, int spd)[] cars = new (int pos, int spd)[n];
        for (int i = 0; i < n; i++) cars[i] = (position[i], speed[i]);
        Array.Sort(cars, (a,b) => b.pos.CompareTo(a.pos));
        int fleats = 0;
        double leadTime = 0;
        foreach(var (pos, spd) in cars) {
            double time = (double)(target - pos)/spd;
            if(time > leadTime) {
                fleats++;
                leadTime = time;
            }
        }
        return fleats;
    }
}
