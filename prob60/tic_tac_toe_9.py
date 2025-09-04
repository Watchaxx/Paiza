# 実行時間 10ms
def judge(c):
    b = False

    if "".join(c) == "OOOOO":
        b = True
        print("O")
    elif "".join(c) == "XXXXX":
        b = True
        print("X")
    return b

def main():
    s = []
    t = []
    u = []

    for _ in [0] * 5:
        i = input()

        if judge(i) == True:
            return
        s.append(i)
    for i in range(5):
        t.clear()
        for j in range(5):
            t.append(s[j][i])
        if judge(t) == True:
            return
    t.clear()
    for i in range(5):
        t.append(s[i][i])
        u.append(s[i][4 - i])
    if judge(t) or judge(u):
        return
    print("D")

main()
