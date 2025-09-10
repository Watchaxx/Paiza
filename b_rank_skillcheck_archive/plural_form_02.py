# 実行時間 10ms
n = int(input())

for _ in [0] * n:
    a = input()

    if a.endswith("s") or a.endswith("sh") or a.endswith("ch") or a.endswith("o") or a.endswith("x"):
        print(f"{a}es")
    else:
        print(f"{a}s")
