# 実行時間 10ms
input()
o = 0
s1 = input()
s2 = input()

for i in range(min(len(s1), len(s2))):
    if s1[i] == s2[i]:
        o += 1
    else:
        break
print(o)
