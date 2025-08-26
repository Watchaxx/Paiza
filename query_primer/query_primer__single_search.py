import sys

n, k = list(map(int, input().split()))

for _ in range(n):
    if int(input()) == k:
        print("YES")
        sys.exit()
print("NO")
