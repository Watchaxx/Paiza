# 実行時間 20ms
r = 0
s = input()

for i in range(len(s) - 1, -1, -1):
    if s[i].isdigit() == True:
        r = i
        break
for i in range(len(s)):
    if s[i].isdigit() != True:
        continue
    print(s[i])

    l = [s[i]]

    for j in range(i + 1, r + 1):
        l.append(s[j])
        if s[j].isdigit() == True:
            print("".join(l))
