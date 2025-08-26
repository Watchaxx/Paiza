from collections import deque

n, k = list(map(int, input().split()))
a = deque()

for _ in range(n):
    a.append(input())
for _ in range(k):
    s = input()

    if s == "pop":
        a.popleft()
    elif s == "show":
        print("\n".join(a))
