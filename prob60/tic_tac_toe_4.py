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

    for _ in [0] * 5:
        s.append(input())
    for i in range(5):
        t.append(s[i][i])
    if judge(t) == True:
        return
    t.clear()
    for i in range(5):
        t.append(s[i][4 - i])
    if judge(t) == True:
        return
    print("D")

main()
