# 実行時間 10ms
n = int(input())

for _ in [0] * n:
    a = input()

    if a.endswith("f"):
        print(f"{a[:-1]}ves")
    elif a.endswith("fe"):
        print(f"{a[:-2]}ves")
    else:
        print(f"{a}s")
