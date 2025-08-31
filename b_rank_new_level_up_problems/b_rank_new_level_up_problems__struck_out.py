# 実行時間 1960ms
import itertools

s = [list(map(int, input().split())) for _ in [0] * 3]
s = [item for sublist in s for item in sublist]
b = [[0 for _ in [0] * 4] for _ in [0] * 9]
a = 0
o = sum(s)

for i in range(9):
    t = list(map(int, input().split()))

    for j in range(len(t)):
        b[i][j] = t[j]
for i in itertools.permutations(list(range(9))):
    t = 0
    op = [False for _ in [0] * 9]

    for j in range(9):
        l = 0
        p = i[j]

        if p == 0:
            l += op[1] and op[2]
            l += op[3] and op[6]
            l += op[4] and op[8]
        elif p == 1:
            l += op[0] and op[2]
            l += op[4] and op[7]
        elif p == 2:
            l += op[0] and op[1]
            l += op[4] and op[6]
            l += op[5] and op[8]
        elif p == 3:
            l += op[0] and op[6]
            l += op[4] and op[5]
        elif p == 4:
            l += op[0] and op[8]
            l += op[1] and op[7]
            l += op[2] and op[6]
            l += op[3] and op[5]
        elif p == 5:
            l += op[2] and op[8]
            l += op[3] and op[4]
        elif p == 6:
            l += op[0] and op[3]
            l += op[2] and op[4]
            l += op[7] and op[8]
        elif p == 7:
            l += op[1] and op[4]
            l += op[6] and op[8]
        elif p == 8:
            l += op[0] and op[4]
            l += op[2] and op[5]
            l += op[6] and op[7]
        if 0 < l:
            t += b[p][l - 1]
        op[p] = True
    a = max(a, t)
print(a + o)
