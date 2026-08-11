public class TimeMap {

    private Dictionary<string, List<(string value, int timestamp)>> map;
    
    public TimeMap() {
        map = new Dictionary<string, List<(string value, int timestamp)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)) { 
            map[key] = new List<(string value, int timestamp)>();
        }
        map[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)) return "";
        var list = map[key];
        int left = 0; int right = list.Count - 1;
        int index = int.MaxValue;
        while(left <= right) {
            int mid = left + (right-left)/2;
            if(list[mid].timestamp <= timestamp) {
                index = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        if(index != int.MaxValue) {
            return map[key][index].value;
        }
        return "";
    }
}
