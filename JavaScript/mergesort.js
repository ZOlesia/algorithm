function merge(arr1, arr2){
    var arr = [];
    while(arr1.length!==0 && arr2.length!==0){
        if(arr1[0] < arr2[0]){
            arr.push(arr1.shift());
        } else{
            arr.push(arr2.shift());
        }
    }

    if(arr1.length==0){
        arr = arr.concat(arr2);
    } 
    if(arr2.length==0){
        arr = arr.concat(arr1);
    }
    return arr;
}


function mergeSort(arr, start=0, end=arr.length-1){
    if(start==end){
        return [arr[end]];
    }
    var mid = Math.floor((start+end)/2);
    return merge(mergeSort(arr, start, mid), mergeSort(arr, mid+1, end));
}





function MergeArr(nums1,  m,  nums2,  n) {
        
    if(m + n > nums1.Length) return 10;
    
    var holder = 0;
    var j = 0;
    
    for(var i = 0; i < nums1.length; i++)
    {
        if((nums2[j] > nums1[i] && nums2[j] <= nums1[i+1]) || nums2[j] < nums1[i])
        {
            if(nums1[i] == 0) 
            {
                nums1[i] = nums2[j];
                j++;
            }
            
            holder = nums1[i+1];
            
            while(holder < nums1.Length)
            {
                if(nums1[holder] == 0) 
                {
                    nums1[holder] = nums1[i];
                    break;
                }
            }
            
            nums1[i] = nums2[j];
            j++;
        }
        
        if(j >= nums2.Length) return 20;
    }

}
     MergeArr([1,2,3,0,0,0], 3, [2, 5, 6], 3);
