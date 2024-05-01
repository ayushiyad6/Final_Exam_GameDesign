nums = [2, 15, 11, 7]

dict6 = {}

target = 9

output = []

for i in range(len(nums)):

    if (target - nums[i]) in dict6:
        print(dict6[target-nums[i]])
        print(i)
    
    else:

        dict6[nums[i]] = i

