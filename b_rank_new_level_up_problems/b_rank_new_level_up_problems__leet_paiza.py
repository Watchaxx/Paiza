# 実行時間 20ms
import sys

P = "paiza"
s = []

for c in input():
    s.append(c)
if P in "".join(s):
    print(P)
    sys.exit()
for i in range(len(s)):
    if s[i] == "4" or s[i] == "@":
        s[i] = "a"
    elif s[i] == "1" or s[i] == "!":
        s[i] = "i"
    elif s[i] == "2":
        s[i] = "z"
print("leet" if P in "".join(s) else "nothing")
