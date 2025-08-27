n = int(input())
d = {}
l = []

for _ in range(n):
    s = input().split()

    if s[1] == "give":
        if s[0] not in d:
            d[s[0]] = int(s[2])
        else:
            d[s[0]] += int(s[2])
    elif s[1] == "join":
        l.append(s[0])
for k, v in sorted(d.items(), key=lambda x: (x[1], x[0]), reverse=True):
    print(k)
l.sort()
print("\n".join(l))
# 実行時間 220ms
