n, k = list(map(int, input().split()))
d = {}

for _ in range(n):
    s = input().split()

    d[s[0]] = s[1]
for _ in range(k):
    print(d[input()])
