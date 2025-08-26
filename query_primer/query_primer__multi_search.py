n, q = list(map(int, input().split()))
a = []

for _ in range(n):
    a.append(int(input()))
for _ in range(q):
    print("YES" if int(input()) in a else "NO")
