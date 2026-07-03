class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {
        let retVal = [];
        let freqObj = {};
        for(let i=0;i<nums.length;i++){
            if(!freqObj[nums[i]]) freqObj[nums[i]] = 1;
            else freqObj[nums[i]]+=1;
        }
        for(let j=0; j<k;j++){
            let max, key;
            for(const h in freqObj){
                if(max === undefined || max<freqObj[h]) {max = freqObj[h]; key = h;}
            }
            delete freqObj[key];
            retVal.push(key);
        }
        return retVal;
    }
}
