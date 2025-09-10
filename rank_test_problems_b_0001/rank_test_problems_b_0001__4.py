# 実行時間 10ms
i = 0
s = input()

while i <= len(s) - 5:
    t = s[i : i + 5]

    if t == "LLLRB":
        i += 5
        print("rolling")
    elif t == "DDRRA":
        i += 5
        print("upper")
    elif t == "AAAAA":
        i += 5
        print("rush")
    else:
        i += 1
