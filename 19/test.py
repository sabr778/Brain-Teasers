import random
# simulating toss the dice
NUM = 100000
cnt = [1,0,0,0,0,0,0]
for i in range(1,NUM+1):
	sum = 0
	a = 0
	while sum < 100:
		a = random.randint(1,6)
		sum += a
	cnt[a] += 1
for i in range(1,7):
	a = float(cnt[i])/NUM
	print "%d \t %f" % (i, a)