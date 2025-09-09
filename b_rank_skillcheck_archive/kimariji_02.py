# 実行時間 10ms
input()
s1 = input()
s2 = input()

for i in range(min(len(s1), len(s2))):
    print("Yes" if s1[i] == s2[i] else "No")
